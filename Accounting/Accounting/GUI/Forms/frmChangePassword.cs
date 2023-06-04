using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces.IRepositories;
using Accounting.Utilities;
using AccountingDLL;
using System;
using System.Windows.Forms;

namespace Accounting.GUI.Forms
{
    public partial class frmChangePassword : Form
    {

        User _user;
        public frmChangePassword()
        {
            InitializeComponent();
            _user = new User();


        }



        void reset()
        {
            txtNewPass.Text = "";
            txtOldPass.Text = "";
            txtRepeatNewPass.Text = "";
            txtUserName.Text = "";



        }
        private async void btnOK_Click(object sender, EventArgs e)
        {





            if (WorkWithStrings.StringIsNullOrEmptyOrWhiteSpace(txtUserName.Text, txtOldPass.Text, txtNewPass.Text, txtRepeatNewPass.Text))
            {
                MessageBox.Show("ورودی یا ورودی های نامعتبر", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            if (WorkWithPassword.PassIsValid(txtOldPass.Text, txtNewPass.Text, txtRepeatNewPass.Text))
            {
                _user.UserName = txtUserName.Text;
                _user.Password = WorkWithEncryption.EncryptPassword(txtOldPass.Text);
                using (UnitOfWork _UnitOfWork = new UnitOfWork())
                {
                    IUserRepository _IUserRepository = _UnitOfWork.UserRepository;
                    IRegistrationRepository _registrationRepository = _UnitOfWork.RegistrationRepository;
                    bool result = await _IUserRepository.IsExist<User>(n => n.UserName == _user.UserName && n.Password == _user.Password);
                    if (!result)
                    {
                        MessageBox.Show(" کاربری با این مشخصات وجود ندارد");
                        return;
                    }
                    bool ChangeUserPasswordResult = await _IUserRepository.ChangeUserPasswordByUser(_user, WorkWithEncryption.EncryptPassword(txtNewPass.Text));
                    bool registrationUpdatePasswordByUserResult = await _registrationRepository.UpdatePasswordByUser(txtUserName.Text, WorkWithEncryption.EncryptPassword(txtNewPass.Text));


                    if (ChangeUserPasswordResult && registrationUpdatePasswordByUserResult)
                    {
                        MessageBox.Show("رمز عبور باموفقیت تغییر یافت", "موفق", MessageBoxButtons.OK, MessageBoxIcon.None);
                        return;
                        reset();
                    }
                    else
                    {
                        MessageBox.Show("خطایی رخ داده", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
            }
            else
            {
                MessageBox.Show("رمز عبور نامعتبر است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOldPass.Text = "";
                txtNewPass.Text = "";
                txtRepeatNewPass.Text = "";
            }

        }

        private void frmChangePassword_FormClosing(object sender, FormClosingEventArgs e)
        {

            this.DialogResult = DialogResult.OK;
        }














        //--------------
    }
}
