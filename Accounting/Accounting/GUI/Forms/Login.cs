using Accounting.DataLayer.Context;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Accounting.GUI.Forms
{
    public partial class Login : Form
    {
        #region class Fields
        User UserTemp;
        #endregion
        public Login()
        {
            InitializeComponent();
            UserTemp = new User();
        }

       
    private void Login_Load(object sender, EventArgs e)
        {
           
            txtUserName.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            

                if (WorkWithTextboxes.TextBoxisNull(cbRole.Text))
                {

                    MessageBox.Show("لطفا نقش خود را مشخص کنید", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cbRole.Focus();
                }
                else if (WorkWithTextboxes.TextBoxisNull(txtUserName.Text))
                {

                    MessageBox.Show("لطفا نام کاربری خود را وارد کنید", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserName.Focus();
                }
                else if (WorkWithTextboxes.TextBoxisNull(txtPassword.Text))
                {

                    MessageBox.Show("لطفا کلمه عبور خود را وارد کنید", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Focus();
                }

                else
                {
                    UserTemp.UserName = txtUserName.Text.Trim();
                    UserTemp.User_Password = txtPassword.Text.Trim();
                    UserTemp.Role = cbRole.Text;

                    using (UnitOfWork _UnitOfWork = new UnitOfWork())
                    {
                        IUserRepository IUserRepository = _UnitOfWork.UserRepository;
                        if (IUserRepository.UserExist(UserTemp))
                        {
                            this.Hide();
                            frmMainMenu frm = new frmMainMenu();
                            frm.Show();
                            frm.lblUser.Text = cbRole.Text;






                        }
                        else
                        {
                            MessageBox.Show("کاربری با این مشخصات یافت نشد ");
                            txtPassword.Text = "";
                            txtUserName.Text = "";
                        }

                    }


                }

            
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
