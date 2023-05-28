using Accounting.Utilities;
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
    public partial class frmLoginDetails : Form
    {
        public frmLoginDetails()
        {
            InitializeComponent();
        }

        private void frmLoginDetails_Load(object sender, EventArgs e)
        {
            lblUserName.Text=  WorkWithGlobalVariables.LoginedUserName;
            lblUserRole.Text = WorkWithGlobalVariables.LoginedUserRole;
            lblUserLoginTime.Text = WorkWithGlobalVariables.LoginedUserTime.ToString();
        }
    }
}
