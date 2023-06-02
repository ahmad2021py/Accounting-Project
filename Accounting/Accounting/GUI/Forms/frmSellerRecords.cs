using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces.IRepositories;
using AccountingDLL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Accounting.GUI.Forms
{
    public partial class frmSellerRecords : Form
    {
        public frmSellerRecords()
        {
            InitializeComponent();
        }

        public string _Address;
        public string _ZipCode;
        public string _City;
        public string _Email;
        public string _State;
        public string _Phone;
        public string _Name;
        public string _NationalCode;
        public string _creditor;
        public string _debtor;



        async void LoadData()
        {
            using (UnitOfWork _UnitOfWork = new UnitOfWork())
            {
                ISellerRepository sellerRepository = _UnitOfWork.SellerRepository;
                //--------
                IEnumerable<Seller> IEnamrableSellerDbRecords = await sellerRepository.GetAll<Seller>(n => n == n);
                DGV1.DataSource = IEnamrableSellerDbRecords;
                DGV1.Columns["Row"].HeaderText = "ردیف";
                DGV1.Columns["NationalCode"].HeaderText = " کد ملی";
                DGV1.Columns["Name"].HeaderText = " نام";
                DGV1.Columns["Phone"].HeaderText = " تلفن";
                DGV1.Columns["State"].HeaderText = " استان";
                DGV1.Columns["ZipCode"].HeaderText = " کد پستی";
                DGV1.Columns["Email"].HeaderText = " ایمیل";
                DGV1.Columns["City"].HeaderText = " شهر";
                DGV1.Columns["Address"].HeaderText = " آدرس";
                DGV1.Columns["debtor"].HeaderText = "بدهکار";
                DGV1.Columns["creditor"].HeaderText = " بستانکار";

                //----------------------------------



            }
        }


        async private void txtNationalCode_TextChanged(object sender, EventArgs e)
        {
            if (txtNationalCode.Text == "")
            {
                LoadData();
                return;
            }


            using (UnitOfWork _UnitOfWork = new UnitOfWork())
            {
                ISellerRepository _SellerRepository = _UnitOfWork.SellerRepository;


                IEnumerable<Seller> IEnamrableSellerDbRecords = await _SellerRepository.GetAll<Seller>(n => n.NationalCode.ToString().Contains(txtNationalCode.Text));
                DGV1.DataSource = IEnamrableSellerDbRecords;



            }


        }

        async private void txtSellerName_TextChanged(object sender, EventArgs e)
        {
            if (txtSellerName.Text == "")
            {
                LoadData();
                return;
            }



            using (UnitOfWork _UnitOfWork = new UnitOfWork())
            {
                ISellerRepository _SellerRepository = _UnitOfWork.SellerRepository;


                IEnumerable<Seller> IEnamrableSellerDbRecords = await _SellerRepository.GetAll<Seller>(n => n.Name.Contains(txtSellerName.Text));

                DGV1.DataSource = IEnamrableSellerDbRecords;



            }

        }

        private void btnExcelExport_Click(object sender, EventArgs e)
        {
            WorkWithExcel.ExportExcel(DGV1);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {

        }

        private void frmSellerRecords_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void DGV1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
         
            _NationalCode = DGV1.Rows[e.RowIndex].Cells["NationalCode"].Value.ToString();
            _Name = DGV1.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            _Phone = DGV1.Rows[e.RowIndex].Cells["Phone"].Value.ToString();
            _State = DGV1.Rows[e.RowIndex].Cells["State"].Value.ToString();
            _Email = DGV1.Rows[e.RowIndex].Cells["Email"].Value.ToString();
            _City = DGV1.Rows[e.RowIndex].Cells["City"].Value.ToString();
            _ZipCode = DGV1.Rows[e.RowIndex].Cells["ZipCode"].Value.ToString();
            _Address = DGV1.Rows[e.RowIndex].Cells["Address"].Value.ToString();
            _creditor = DGV1.Rows[e.RowIndex].Cells["creditor"].Value.ToString();
            _debtor = DGV1.Rows[e.RowIndex].Cells["debtor"].Value.ToString();
            this.DialogResult = DialogResult.OK;
        }
    }
}
