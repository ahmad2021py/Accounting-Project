using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces.IRepositories;
using Accounting.Utilities;
using System;
using System.Windows.Forms;

namespace Accounting.GUI.Forms
{
    public partial class frmRecoveryPassword : Form
    {
        WorkWithEmail.SupportEmailPacket _emailPacket;
        public frmRecoveryPassword()
        {
            InitializeComponent();

        }

        async private void btnSend_Click(object sender, EventArgs e)
        {
            if (WorkWithStrings.StringIsNullOrEmptyOrWhiteSpace(txtUserName.Text))
            {

                MessageBox.Show("ورودی نامعتبر");
                return;
            }



            bool IsValidateEmailResult = WorkWithEmail.IsValidateEmail(txtEmail.Text);
            if (!IsValidateEmailResult)
            {
                MessageBox.Show("لطفا یک ایمیل معتبر وارد کنید");
                return;
            }


            Cursor = Cursors.WaitCursor;

            using (UnitOfWork _UnitOfWork = new UnitOfWork())
            {
                IRegistrationRepository registrationRepository = _UnitOfWork.RegistrationRepository;

                bool RegistrationIsValid = await registrationRepository.IsExist<Registration>(n => n.Email == txtEmail.Text && n.UserName == txtUserName.Text);

                if (!RegistrationIsValid)
                {
                    MessageBox.Show("کاربری با این مشخصات یافت نشد ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string Password = "";
                try
                {
                    Password = await registrationRepository.GetUserPassword(txtUserName.Text, txtEmail.Text);
                }

                catch
                {
                    MessageBox.Show("خطایی در دریافت اطلاعات کاربر به وجود آمده", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Password = WorkWithEncryption.DecryptPassword(Password);
                _emailPacket = new WorkWithEmail.SupportEmailPacket(txtEmail.Text, txtUserName.Text, Password);
                bool Result = await WorkWithEmail.SendRecoveryMail(_emailPacket);
                if (Result)
                {
                    MessageBox.Show("پسورد به ایمیل شما ارسال شد", "موفق", MessageBoxButtons.OK, MessageBoxIcon.None);

                }
                else
                {
                    MessageBox.Show("خطایی رخ داده است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }


        }



        private void frmRecoveryPassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }























        //--------------------------------------
    }

}

