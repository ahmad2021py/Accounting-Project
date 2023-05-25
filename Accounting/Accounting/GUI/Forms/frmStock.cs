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
    public partial class frmStock : Form
    {
        public frmStock()
        {
            InitializeComponent();
        }

    

        private void btnShowFrmProduct_Click(object sender, EventArgs e)
        {
            frmProduct frm = new frmProduct();
            frm.txtProductCode.Text =txtProductCode.Text;
            
            frm.ShowDialog();

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            frmProductRecords frm = new frmProductRecords(this);
            frm.Show();
            this.Hide();


        }

        private void btnShowFrmStockRecords_Click(object sender, EventArgs e)
        {
            frmStockRecords frm = new frmStockRecords();
            frm.ShowDialog();
        }
    }
}
