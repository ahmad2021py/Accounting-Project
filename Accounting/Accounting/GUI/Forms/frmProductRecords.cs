using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces;
using Accounting.Utilities;
using AccountingDLL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Accounting.GUI.Forms
{
    public partial class frmProductRecords : Form
    {
        //------------Fields----------------

        //-------Methods--------------------------
        public frmProductRecords(Form parent)
        {
            InitializeComponent();
            this.Owner = parent;

        }

        public string _id;
        public string _ProductName;
        public string _Features;
        public string _Price;
        public string _Company;
        public string _Category;
        public Image _Picture;


        async void LoadData()
        {
            using (UnitOfWork _UnitOfWork = new UnitOfWork())
            {
                IProductRepository _ProductRepository = _UnitOfWork.ProductRepository;
               
                    //--------

                    IEnumerable<Product> DbEnabrableRecords = await _ProductRepository.GetAll<Product>(n => n == n);
                    DGV1.DataSource = DbEnabrableRecords;
                    DGV1.Columns["id"].HeaderText = " کد محصول";
                    DGV1.Columns["ProductName"].HeaderText = " نام محصول";
                    DGV1.Columns["Features"].HeaderText = " ویژگی";
                    DGV1.Columns["Price"].HeaderText = " قیمت";
                    DGV1.Columns["Company"].HeaderText = " شرکت";
                    DGV1.Columns["Category"].HeaderText = " دسته بندی";
                    DGV1.Columns["Picture"].Visible = false;//Picture Column
                                                            //----------------------------------


            }
        }

        private void frmConfigRecords_Load(object sender, EventArgs e)
        {


            LoadData();



        }

        private async void txtProductName_TextChanged(object sender, EventArgs e)
        {
            if (txtProductName.Text == "")
            {
                LoadData();
                return;
            }

            using (UnitOfWork _UnitOfWork = new UnitOfWork())
            {
                IProductRepository _ProductRepository = _UnitOfWork.ProductRepository;
               
                    string productName = txtProductName.Text;
                    IEnumerable<Product> IEnamrableProductDbRecords = await _ProductRepository.GetAll<Product>(n => n.ProductName.Contains(productName));
                    DGV1.DataSource = IEnamrableProductDbRecords;

               

            }

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            WorkWithExcel.ExportExcel(DGV1);
        }

       

        private async void txtCompany_TextChanged(object sender, EventArgs e)
        {
            if (txtCompany.Text == "")
            {
                LoadData();
                return;
            }

            using (UnitOfWork _UnitOfWork = new UnitOfWork())
            {
                IProductRepository _ProductRepository = _UnitOfWork.ProductRepository;
               
                string Company = txtCompany.Text;
                    IEnumerable<Product> EnamrableProductDbRecords = await _ProductRepository.GetAll<Product>(n => n.Company.Contains(Company));
                    DGV1.DataSource = EnamrableProductDbRecords;

            

            }

        }

        private async void txtCategory_TextChanged(object sender, EventArgs e)
        {
            if (txtCategory.Text == "")
            {
                LoadData();
                return;
            }

            using (UnitOfWork _UnitOfWork = new UnitOfWork())
            {
                IProductRepository _ProductRepository = _UnitOfWork.ProductRepository;
                
                    string category = txtCategory.Text;
                    IEnumerable<Product> IEnamerableProductDbRecords = await _ProductRepository.GetAll<Product>(n => n.Category.Contains(category));
                    DGV1.DataSource = IEnamerableProductDbRecords;

           

            }

        }


        private void frmProductRecords_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void DGV1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
            //this.Hide();
            if (this.Owner.Name == "frmProduct")
            {











                _id = DGV1.Rows[e.RowIndex].Cells["id"].Value.ToString();
                _ProductName = DGV1.Rows[e.RowIndex].Cells["ProductName"].Value.ToString();
                _Features = DGV1.Rows[e.RowIndex].Cells["Features"].Value.ToString();
                _Price = DGV1.Rows[e.RowIndex].Cells["Price"].Value.ToString();
                _Category = DGV1.Rows[e.RowIndex].Cells["Category"].Value.ToString();
                _Company = DGV1.Rows[e.RowIndex].Cells["Company"].Value.ToString();
                byte[] data = (byte[])DGV1.Rows[e.RowIndex].Cells["Picture"].Value;
                MemoryStream ms = new MemoryStream(data);
                _Picture = Image.FromStream(ms);
                this.DialogResult = DialogResult.OK;
            }
            else if (this.Owner.Name == "frmStock")
            {

                _id = DGV1.Rows[e.RowIndex].Cells["id"].Value.ToString();
                _ProductName = DGV1.Rows[e.RowIndex].Cells["ProductName"].Value.ToString();
                _Category = DGV1.Rows[e.RowIndex].Cells["Category"].Value.ToString();
                _Company = DGV1.Rows[e.RowIndex].Cells["Company"].Value.ToString();
                _Features = DGV1.Rows[e.RowIndex].Cells["Features"].Value.ToString();
                _Price = DGV1.Rows[e.RowIndex].Cells["Price"].Value.ToString();
                this.DialogResult = DialogResult.OK;

            }
        }


























        //---End Block of Class And Namespace------------------------
    }
}
