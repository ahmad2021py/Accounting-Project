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
                try
                {
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
                catch
                {
                    MessageBox.Show(" خطایی رخ داده است");
                }
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
                try
                {
                    string productName = txtProductName.Text;
                    IEnumerable<Product> IEnamrableProductDbRecords = await _ProductRepository.GetAll<Product>(n => n.ProductName.Contains(productName));
                    DGV1.DataSource = IEnamrableProductDbRecords;

                }
                catch
                {
                    MessageBox.Show(" خطایی رخ داده است");
                }

            }

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            WorkWithExcel.ExportExcel(DGV1);
        }

        private void DGV1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                DataGridViewRow dr = DGV1.SelectedRows[0];
                //this.Hide();
                if (this.Owner.Name == "frmProduct")
                {











                    _id = dr.Cells["id"].Value.ToString();
                    _ProductName = dr.Cells["ProductName"].Value.ToString();
                    _Features = dr.Cells["Features"].Value.ToString();
                    _Price = dr.Cells["Price"].Value.ToString();
                    _Category = dr.Cells["Category"].Value.ToString();
                    _Company = dr.Cells["Company"].Value.ToString();
                    byte[] data = (byte[])dr.Cells["Picture"].Value;
                    MemoryStream ms = new MemoryStream(data);
                    _Picture = Image.FromStream(ms);
                    this.DialogResult = DialogResult.OK;
                }
                else if (this.Owner.Name == "frmStock")
                {

                    _id = dr.Cells["id"].Value.ToString();
                    _ProductName = dr.Cells["ProductName"].Value.ToString();
                    _Category = dr.Cells["Category"].Value.ToString();
                    _Company = dr.Cells["Company"].Value.ToString();
                    _Features = dr.Cells["Features"].Value.ToString();
                    _Price = dr.Cells["Price"].Value.ToString();
                    this.DialogResult = DialogResult.OK;

                }


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ////-------------------------------------------------------
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
                try
                {
                    string Company = txtCompany.Text;
                    IEnumerable<Product> EnamrableProductDbRecords = await _ProductRepository.GetAll<Product>(n => n.Company.Contains(Company));
                    DGV1.DataSource = EnamrableProductDbRecords;

                }
                catch
                {
                    MessageBox.Show(" خطایی رخ داده است");
                }

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
                try
                {
                    string category = txtCategory.Text;
                    IEnumerable<Product> IEnamerableProductDbRecords = await _ProductRepository.GetAll<Product>(n => n.Category.Contains(category));
                    DGV1.DataSource = IEnamerableProductDbRecords;

                }
                catch
                {
                    MessageBox.Show(" خطایی رخ داده است");
                }

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Owner.Show();
        }

        private void frmProductRecords_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

























        //---End Block of Class And Namespace------------------------
    }
}
