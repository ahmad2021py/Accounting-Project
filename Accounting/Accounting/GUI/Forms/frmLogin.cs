using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces.IRepositories;
using Accounting.Utilities;
using AccountingDLL;
using System;
using System.Windows.Forms;

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

            frmMainMenu frm = new frmMainMenu();


            //frm.lblUser.Text = cbRole.Text;
            //frm.toolStripStatusLabel3.Text = UserTemp.UserName;
            WorkWithGlobalVariables.LoginedUserName = UserTemp.UserName;
            WorkWithGlobalVariables.LoginedUserRole = cbRole.Text;
            WorkWithDate workWithDate = new WorkWithDate();
            WorkWithGlobalVariables.LoginedUserTime = workWithDate.MiladiToShamsi(DateTime.Now);
            WorkWithGlobalVariables.LoginedUserTime = WorkWithGlobalVariables.LoginedUserTime + " ساعت :  " + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;

            if (cbRole.Text == "Manager")
            {
                //Hide btnRegistration 


                // Hide btnUsers

            }
            else if (cbRole.Text == "Employee")
            {
                //Hide btnRegistration 


                // Hide btnUsers

                //  frm.btnModify.Enabled = false;
                // btnInvoiceRpt.Enabled = false;
                //  frm.butonInvoice.Enabled = false;
                // frm.btnInvoice.Enabled = false;
            }

            frm.Show();
            this.Hide();
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









        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        async private void btnOK_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

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
                UserTemp.Password = WorkWithEncryption.EncryptPassword(txtPassword.Text.Trim());
                UserTemp.Role = cbRole.Text;

                using (UnitOfWork _UnitOfWork = new UnitOfWork())
                {
                    IUserRepository IUserRepository = _UnitOfWork.UserRepository;
                    bool Result = await IUserRepository.IsExist<User>(n => n.UserName == UserTemp.UserName && n.Password == UserTemp.Password && n.Role == UserTemp.Role);
                    if (Result)
                    {
                        frmMainInitialize();
                        Cursor = Cursors.Default;
                    }
                    else
                    {
                        MessageBox.Show("کاربری با این مشخصات یافت نشد ");
                        txtPassword.Text = "";
                        txtUserName.Text = "";
                        Cursor = Cursors.Default;
                    }

                }


            }


        }



        private void linklblRecoveryPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRecoveryPassword frm = new frmRecoveryPassword();
            frm.ShowDialog();
        }

        private void linklblChangePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmChangePassword Frm = new frmChangePassword();
            Frm.ShowDialog();
        }
    }
}
