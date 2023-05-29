using Accounting.DataLayer.Context;
using Accounting.DataLayer.Interfaces;
using Accounting.Utilities;
using AccountingDLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
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
         bool IsValidateEmailResult =   await WorkWithEmail.IsValidateEmail(txtEmail.Text);
            if (!IsValidateEmailResult)
            {
                MessageBox.Show("لطفا یک ایمیل معتبر وارد کنید");
                return;
            }
            Cursor = Cursors.WaitCursor;

            using (UnitOfWork _UnitOfWork = new UnitOfWork())
            {
                IRegistrationRepository IRegistrationRepository = _UnitOfWork.RegistrationRepository;
                bool RegistrationIsValidResult = await IRegistrationRepository.RegistrationIsValid(txtUserName.Text, txtEmail.Text);
                if (!RegistrationIsValidResult)
                {
                    MessageBox.Show("کاربری با این مشخصات یافت نشد ", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string Password = "";
                try
                {
                    Password =await IRegistrationRepository.GetUserPassword(txtUserName.Text, txtEmail.Text);

                    Password = WorkWithEncryption.DecryptPassword(Password);
                }

                catch
                {
                    MessageBox.Show("خطایی در دریافت اطلاعات به وجود آمد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                _emailPacket = new WorkWithEmail.SupportEmailPacket(txtEmail.Text, txtUserName.Text, Password);
                bool Result = await WorkWithEmail.SendRecoveryMail(_emailPacket);
                if (Result)
                {
                    MessageBox.Show("پسورد به ایمیل شما ارسال شد", "موفق", MessageBoxButtons.OK, MessageBoxIcon.None);
                    this.Hide();
                    frmLogin frm = new frmLogin();
                    frm.Show();
                    frm.txtUserName.Text = "";
                    frm.txtPassword.Text = "";
                    frm.txtUserName.Focus();
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

