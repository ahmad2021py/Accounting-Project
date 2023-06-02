using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces.IRepositories;
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
    public partial class frmProductsSoldRecords : Form
    {
        public frmProductsSoldRecords()
        {
            InitializeComponent();
        }




       async void LoadData()
        {


            using (UnitOfWork _UnitOfWork = new UnitOfWork())
            {
                IProductSoldRepository _ProductSoldRepository = _UnitOfWork.ProductSoldRepository;

                //--------

                IEnumerable<ProductSold> DbEnabrableRecords = await _ProductSoldRepository.GetAll<ProductSold>(n => n == n);
                DGV1.DataSource = DbEnabrableRecords;
                DGV1.Columns["ProductSoldTableCode"].HeaderText = " کد فروش";
                DGV1.Columns["FKInvoice"].HeaderText = " کد فاکتور";
                DGV1.Columns["Invoice"].Visible = false;




            }

        }





      async  private void txtProductSoldCode_TextChanged(object sender, EventArgs e)
        {
            if (txtProductSoldCode.Text == "")
            {
                LoadData();
                return;
            }

            using (UnitOfWork _UnitOfWork = new UnitOfWork())
            {
                IProductSoldRepository _ProductSoldRepository = _UnitOfWork.ProductSoldRepository;

                int ProductSoldCode =int.Parse(txtProductSoldCode.Text);
                IEnumerable<ProductSold> IEnamrableProductSoldDbRecords = await _ProductSoldRepository.GetAll<ProductSold>(n => n.ProductSoldTableCode==ProductSoldCode);
                DGV1.DataSource = IEnamrableProductSoldDbRecords;



            }

        }

        private void frmProductsSoldRecords_Load(object sender, EventArgs e)
        {
            LoadData();
        }

       async private void txtFKInvoice_TextChanged(object sender, EventArgs e)
        {
            if (txtFKInvoice.Text == "")
            {
                LoadData();
                return;
            }

            using (UnitOfWork _UnitOfWork = new UnitOfWork())
            {
                IProductSoldRepository _ProductSoldRepository = _UnitOfWork.ProductSoldRepository;

                int FKInvoice = int.Parse(txtFKInvoice.Text);
                IEnumerable<ProductSold> IEnamrableProductSoldDbRecords = await _ProductSoldRepository.GetAll<ProductSold>(n => n.ProductSoldTableCode == FKInvoice);
                DGV1.DataSource = IEnamrableProductSoldDbRecords;



            }

        }

        private void frmProductsSoldRecords_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            WorkWithExcel.ExportExcel(DGV1);
        }
    }
}
