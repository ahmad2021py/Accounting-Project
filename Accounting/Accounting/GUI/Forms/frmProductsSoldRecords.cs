using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces.IRepositories;
using AccountingDLL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Accounting.GUI.Forms
{
    public partial class frmProductsSoldRecords : Form
    {
        public string _ProductSoldTableCode;
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
                DGV1.Columns["FKSellInvoice"].HeaderText = " کد فاکتور فروش";
                DGV1.Columns["SellInvoice"].Visible = false;




            }

        }





        async private void txtProductSoldCode_TextChanged(object sender, EventArgs e)
        {
            if (txtProductSoldCode.Text == "")
            {
                LoadData();
                return;
            }

            using (UnitOfWork _UnitOfWork = new UnitOfWork())
            {
                IProductSoldRepository _ProductSoldRepository = _UnitOfWork.ProductSoldRepository;

                int ProductSoldCode = int.Parse(txtProductSoldCode.Text);
                IEnumerable<ProductSold> IEnamrableProductSoldDbRecords = await _ProductSoldRepository.GetAll<ProductSold>(n => n.ProductSoldTableCode == ProductSoldCode);
                DGV1.DataSource = IEnamrableProductSoldDbRecords;



            }

        }

        private void frmProductsSoldRecords_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        async private void txtFKSellInvoice_TextChanged(object sender, EventArgs e)
        {
            if (txtFKSellInvoice.Text == "")
            {
                LoadData();
                return;
            }

            using (UnitOfWork _UnitOfWork = new UnitOfWork())
            {
                IProductSoldRepository _ProductSoldRepository = _UnitOfWork.ProductSoldRepository;

                IEnumerable<ProductSold> IEnamrableProductSoldDbRecords = await _ProductSoldRepository.GetAll<ProductSold>(n => n.FKSellInvoice == txtFKSellInvoice.Text);
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

        private void DGV1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _ProductSoldTableCode = DGV1.Rows[e.RowIndex].Cells["ProductSoldTableCode"].Value.ToString();
            this.DialogResult = DialogResult.OK;
        }
    }
}
