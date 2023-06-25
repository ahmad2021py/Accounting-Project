using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces.IRepositories;
using Accounting.Utilities;
using AccountingDLL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Accounting.GUI.Forms
{
    public partial class frmChangePassword : Form
    {


        public frmChangePassword()
        {
            InitializeComponent();



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

                using (UnitOfWork _UnitOfWork = new UnitOfWork())
                {
                    IUserRepository _IUserRepository = _UnitOfWork.UserRepository;
                    IRegistrationRepository _registrationRepository = _UnitOfWork.RegistrationRepository;
                    string oldPass = WorkWithEncryption.EncryptPassword(txtOldPass.Text);
                    bool result = await _IUserRepository.IsExist<User>(n => n.UserName == txtUserName.Text && n.Password == oldPass);
                    if (!result)
                    {
                        MessageBox.Show(" کاربری با این مشخصات وجود ندارد");
                        return;
                    }

                    //------Fill PropertyMap ------------

                    List<PropertyMap> userPropertiesToUpdate = new List<PropertyMap> {


                new PropertyMap()
                {

                    PropertyName = "UserName" ,
                    PropertyValue=   txtUserName.Text


                } ,

                 new PropertyMap()
                {

                    PropertyName = "Password",
                    PropertyValue= WorkWithEncryption.EncryptPassword(txtNewPass.Text)


                }
                 };


                    bool ChangeUserPasswordResult = await _IUserRepository.UpdateMany<User>(n => n.UserName == txtUserName.Text && n.Password == oldPass, userPropertiesToUpdate);

                    //------Fill PropertyMap ------------

                    List<PropertyMap> registarationPropertiesToUpdate = new List<PropertyMap> {


                new PropertyMap()
                {

                    PropertyName = "UserName" ,
                    PropertyValue=   txtUserName.Text


                } ,

                 new PropertyMap()
                {

                    PropertyName = "Password",
                    PropertyValue= WorkWithEncryption.EncryptPassword(txtNewPass.Text)


            }
                 };
                    bool registrationUpdatePasswordByUserResult = await _registrationRepository.UpdateMany<Registration>(n => n.UserName == txtUserName.Text, registarationPropertiesToUpdate);
                    if (ChangeUserPasswordResult && registrationUpdatePasswordByUserResult)
                    {
                        MessageBox.Show("رمز عبور باموفقیت تغییر یافت", "موفق", MessageBoxButtons.OK, MessageBoxIcon.None);
                        _UnitOfWork.Save();
                        reset();
                        return;

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
