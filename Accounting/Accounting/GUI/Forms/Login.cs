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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
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



        }
    }
}
