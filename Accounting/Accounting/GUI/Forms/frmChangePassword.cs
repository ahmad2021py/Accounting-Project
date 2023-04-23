using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces;
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
                    _user.User_Password = txtOldPass.Text;
                    using (UnitOfWork _UnitOfWork = new UnitOfWork())
                    {
                        IUserRepository _IUserRepository = _UnitOfWork.UserRepository;
                        if (_IUserRepository.UserExist(_user.UserName,_user.User_Password))
                        if (_IUserRepository.ChangeUserPassword(_user, txtNewPass.Text))
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
    }
}
