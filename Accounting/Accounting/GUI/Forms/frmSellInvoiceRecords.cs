using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Accounting.GUI.Forms
{
    public partial class frmSellInvoiceRecords : Form
    {
        public string _SellInvoiceCode;
        public frmSellInvoiceRecords()
        {
            InitializeComponent();
        }


        async void LoadData()
        {
            using (UnitOfWork _UnitOfWork = new UnitOfWork())
            {
                ISelllnvoiceRepository selllnvoiceRepository = _UnitOfWork.SellInvoiceRepository;
                //--------
                IEnumerable<SellInvoice> IEnamrableSellInvoiceDbRecords = await selllnvoiceRepository.GetAll<SellInvoice>(n => n == n);
                DGV1.DataSource = IEnamrableSellInvoiceDbRecords;
                DGV1.Columns["Row"].HeaderText = "ردیف";
                DGV1.Columns["Off"].HeaderText = " تخیف";
                DGV1.Columns["SellPricePerUnit"].HeaderText = " مبلغ هر واحد";
                DGV1.Columns["TotalSellAmount"].HeaderText = " کل مبلغ فروش";
                DGV1.Columns["Quantity"].HeaderText = " تعداد";
                DGV1.Columns["FKStock"].HeaderText = " کد انبار";
                DGV1.Columns["FKCustomer"].HeaderText = " کد مشتری";
                DGV1.Columns["SellInvoiceDate"].HeaderText = " تاریخ فاکتور";
                DGV1.Columns["SellInvoiceCode"].HeaderText = " کد فاکتور فروش";

                //----------------------------------



            }
        }












        private void frmSellInvoiceRecords_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void DGV1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            _SellInvoiceCode = DGV1.Rows[e.RowIndex].Cells["SellInvoiceCode"].Value.ToString();

            this.DialogResult = DialogResult.OK;

        }
    }
}
