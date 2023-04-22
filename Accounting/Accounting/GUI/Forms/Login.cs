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
                        int i;
                        progressBar1.Visible = true;
                        progressBar1.Maximum = 5000;
                        progressBar1.Minimum = 0;
                        progressBar1.Value = 4;
                        progressBar1.Step = 1;

                        for (i = 0; i <= 5000; i++)
                        {
                            progressBar1.PerformStep();
                        }

                        this.Hide();
                      //  frmMainMenu frm = new frmMainMenu();
                      
                      //  frm.Show();
                      //  frm.lblUser.Text = cbRole.Text;

                        //The following is user defined call for method disable 
                        //ignore the green highlight

                     //   if (cbRole.SelectedItem == "Manager")
                     //   frm.disable();

                       // if (cbRole.SelectedItem == "Employee")
                       // frm.disable1();

                      //  GlobalVariables.UserName = UserTemp.UserName;
                    }

                }
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {
            progressBar1.Visible = false;
            txtUserName.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
          
        }
    }
}
