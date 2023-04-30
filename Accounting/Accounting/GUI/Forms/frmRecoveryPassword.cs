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
        EmailPacket _emailPacket;
        public frmRecoveryPassword()
        {
            InitializeComponent();
            _emailPacket = new EmailPacket();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (WorkWithTextboxes.TextBoxisNull(txtEmail.Text))
            {
                MessageBox.Show("لطفا ایمیل خود را وارد کنید", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
            }
            else
            {
                Cursor = Cursors.WaitCursor;

                // timer1.Enabled = true;
                using (UnitOfWork _UnitOfWork = new UnitOfWork())
                {
                    IRegistrationRepository  IRegistrationRepository = _UnitOfWork.RegistrationRepository;
                    if (IRegistrationRepository.RegistrationIsValid(txtUserName.Text, txtEmail.Text))
                    {
                                            
                       string Password = IRegistrationRepository.GetUserPassword(txtUserName.Text,txtEmail.Text);
                      
                        _emailPacket.From = "ahmad@gmail.com";
                        _emailPacket.destination = txtEmail.Text;
                        _emailPacket.Subject = "ایمیل بازیابی رمز";
                        _emailPacket.Body = "Your Password :  " + Password;

                        if (WorkWithEmail.SendMail(_emailPacket))
                        {
                            MessageBox.Show("پسورد به ایمیل شما ارسال شد", "موفق", MessageBoxButtons.OK, MessageBoxIcon.None);
                            this.Hide();
                            frmLogin LoginForm1 = new frmLogin();
                            LoginForm1.Show();
                            LoginForm1.txtUserName.Text = "";
                            LoginForm1.txtPassword.Text = "";
                            LoginForm1.txtUserName.Focus();
                        }
                        else
                        {
                            MessageBox.Show("خطایی رخ داده است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                    }
                    


                    else
                    {
                        MessageBox.Show("خطایی رخ داده است ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }


            }
        }

    }

}

