﻿using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces;
using Accounting.Utilities;
using AccountingDLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(WorkWithTextboxes.TextBoxisNull(txtUserName.Text, txtOldPass.Text, txtNewPass.Text, txtRepeatNewPass.Text)){
                MessageBox.Show("لطفا تمام فیلد ها را پر کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
               if( WorkWithPassword.PassIsValid(txtOldPass.Text, txtNewPass.Text,txtRepeatNewPass.Text))
                 {
                    _user.UserName = txtUserName.Text;
                    _user.Password = WorkWithEncryption.EncryptPassword( txtOldPass.Text);
                    using (UnitOfWork _UnitOfWork = new UnitOfWork())
                    {
                        IUserRepository _IUserRepository = _UnitOfWork.UserRepository;
                        if (_IUserRepository.IsExist<User>(n=>n.UserName==_user.UserName&&n.Password==_user.Password))
                        if (_IUserRepository.ChangeUserPassword(_user, WorkWithEncryption.EncryptPassword( txtNewPass.Text)))
                        {
                            MessageBox.Show("رمز عبور باموفقیت تغییر یافت", "موفق", MessageBoxButtons.OK, MessageBoxIcon.None);
                                this.Close();
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
        }

        private void frmChangePassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmLogin frm = new frmLogin();

            frm.Show();
            this.Hide();
        }
    }
}
