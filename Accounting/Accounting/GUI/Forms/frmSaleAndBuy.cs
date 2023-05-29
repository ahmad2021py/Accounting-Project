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
    public partial class frmSaleAndBuy : Form
    {
        public frmSaleAndBuy()
        {
            InitializeComponent();
        }

        private void frmSale_Load(object sender, EventArgs e)
        {

        }

        private void frmSaleAndBuy_FormClosed(object sender, FormClosedEventArgs e)
        {

            frmMainMenu frm = new frmMainMenu();
            frm.Show();
            this.Hide();

        }

        private void frmSaleAndBuy_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
