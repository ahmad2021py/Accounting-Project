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
    public partial class frmLogin : Form
    {
        //-----Fields-------------------
        #region class Fields
        User UserTemp;
        #endregion
        //------Methods------------
        #region frmMainInitialize Method
        void frmMainInitialize()
        {
            this.Hide();
            frmMainMenu frm = new frmMainMenu();
            frm.Show();
            //frm.lblUser.Text = cbRole.Text;
            //frm.toolStripStatusLabel3.Text = UserTemp.UserName;
            GlobalVariables.LoginedUserName = UserTemp.UserName;
            GlobalVariables.LoginedUserRole = cbRole.Text;
            GlobalVariables.LoginedUserTime = DateTime.Now;
            if (cbRole.Text == "Manager")
            {
                //Hide btnRegistration 
                frm.btnRegistration.Enabled = false;
                frm.btnRegistration.Visible = false;
                frm.lblRegistration.Visible = false;
                // Hide btnUsers
                frm.btnUsers.Enabled = false;
                frm.btnUsers.Visible = false;
                frm.lblUsers.Visible = false;
            }
            else if (cbRole.Text == "Employee")
            {
                //Hide btnRegistration 
                frm.btnRegistration.Enabled = false;
                frm.btnRegistration.Visible = false;
                frm.lblRegistration.Visible = false;
                // Hide btnUsers
                frm.btnUsers.Enabled = false;
                frm.btnUsers.Visible = false;
                frm.lblUsers.Visible = false;

                //  frm.btnModify.Enabled = false;
                // btnInvoiceRpt.Enabled = false;
                //  frm.butonInvoice.Enabled = false;
                // frm.btnInvoice.Enabled = false;
            }
        }
        #endregion


        public frmLogin()
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

        private async void btnOK_Click(object sender, EventArgs e)
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
                UserTemp.User_Password = Encryption.EncryptPassword(txtPassword.Text.Trim());
                UserTemp.Role = cbRole.Text;

                using (UnitOfWork _UnitOfWork = new UnitOfWork())
                {
                    IUserRepository IUserRepository = _UnitOfWork.UserRepository;
                    bool Result =await IUserRepository.UserExist(UserTemp);
                    if (Result)
                    {
                        frmMainInitialize();
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
            frmRecoveryPassword frm = new frmRecoveryPassword();
            frm.ShowDialog();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmChangePassword Frm = new frmChangePassword();
            Frm.ShowDialog();

        }
    }
}
