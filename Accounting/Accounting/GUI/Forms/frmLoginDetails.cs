using Accounting.Utilities;
using System;
using System.Windows.Forms;

namespace Accounting.GUI.Forms
{
    public partial class frmLoginDetails : Form
    {
        public frmLoginDetails()
        {
            InitializeComponent();
        }

        private void frmLoginDetails_Load(object sender, EventArgs e)
        {
            lblUserName.Text = WorkWithGlobalVariables.LoginedUserName;
            lblUserRole.Text = WorkWithGlobalVariables.LoginedUserRole;
            lblUserLoginTime.Text = WorkWithGlobalVariables.LoginedUserTime.ToString();
        }



        private void frmLoginDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
