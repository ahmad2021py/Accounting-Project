using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces;
using AccountingDLL;
using System;
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
        void LoadData()
        {
            using (UnitOfWork _UnitOfWork = new UnitOfWork())
            {
                IProductRepository _ProductRepository = _UnitOfWork.ProductRepository;
                try
                {
                    //--------
                    DGV1.DataSource = _ProductRepository.GetAll<Product>(n=>n==n);
                    DGV1.Columns["ProductId"].HeaderText = " کد محصول";
                    DGV1.Columns["ProductName"].HeaderText = " نام محصول";
                    DGV1.Columns["Features"].HeaderText = " ویژگی";
                    DGV1.Columns["Price"].HeaderText = " قیمت";
                    DGV1.Columns["Price"].HeaderText = " قیمت";
                    DGV1.Columns["Company"].HeaderText = " قیمت";
                    DGV1.Columns["Category"].HeaderText = " قیمت";
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

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {
            if (txtProductName.Text == "")
            {
                LoadData();
            }
            else
            {
                using (UnitOfWork _UnitOfWork = new UnitOfWork())
                {
                    IProductRepository _ProductRepository = _UnitOfWork.ProductRepository;
                    try
                    {
                        string productName = txtProductName.Text;
                        DGV1.DataSource = _ProductRepository.GetAll<Product>(n=>n.ProductName.Contains(productName));

                    }
                    catch
                    {
                        MessageBox.Show(" خطایی رخ داده است");
                    }

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
                this.Hide();
                if (this.Owner.Name == "frmProduct")
                {
                    frmProduct obj = new frmProduct();


                    obj.txtProductCode.Text = dr.Cells["ProductId"].Value.ToString();
                    obj.txtProductName.Text = dr.Cells["ProductName"].Value.ToString();
                    obj.txtFeatures.Text = dr.Cells["Features"].Value.ToString();
                    obj.txtPrice.Text = dr.Cells["Price"].Value.ToString();
                    obj.cbCategory.Text = dr.Cells["Category"].Value.ToString();
                    obj.cbCompany.Text = dr.Cells["Company"].Value.ToString();
                    byte[] data = (byte[])dr.Cells["Picture"].Value;
                    MemoryStream ms = new MemoryStream(data);
                    obj.PboxProductPicture.Image = Image.FromStream(ms);
                    obj.Show();
                    obj.txtProductCode.Focus();
                    this.Close();
                }
                else if (this.Owner.Name == "frmStock")
                {

                    frmStock obj = new frmStock();


                    obj.txtProductCode.Text = dr.Cells["ProductId"].Value.ToString();
                    obj.label16.Text = dr.Cells["Category"].Value.ToString();
                    obj.label17.Text = dr.Cells["ProductName"].Value.ToString();
                    obj.label18.Text = dr.Cells["Company"].Value.ToString();
                    obj.label19.Text = dr.Cells["Features"].Value.ToString();
                    obj.label20.Text = dr.Cells["Category"].Value.ToString();
                    obj.label21.Text = dr.Cells["Price"].Value.ToString();
                    obj.Show();
                    obj.txtProductCode.Focus();
                    this.Close();
                }


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //-------------------------------------------------------

        }

        private void txtCompany_TextChanged(object sender, EventArgs e)
        {
            if (txtCompany.Text == "")
            {
                LoadData();
            }
            else
            {
                using (UnitOfWork _UnitOfWork = new UnitOfWork())
                {
                    IProductRepository _ProductRepository = _UnitOfWork.ProductRepository;
                    try
                    {
                        string Company = txtCompany.Text;
                        DGV1.DataSource = _ProductRepository.GetAll<Product>(n => n.Company.Contains(Company));

                    }
                    catch
                    {
                        MessageBox.Show(" خطایی رخ داده است");
                    }

                }
            }
        }

        private void txtCategory_TextChanged(object sender, EventArgs e)
        {
            if (txtCategory.Text == "")
            {
                LoadData();
            }
            else
            {
                using (UnitOfWork _UnitOfWork = new UnitOfWork())
                {
                    IProductRepository _ProductRepository = _UnitOfWork.ProductRepository;
                    try
                    {
                        string category = txtCategory.Text;
                        DGV1.DataSource = _ProductRepository.GetAll<Product>(n => n.Category.Contains(category));

                    }
                    catch
                    {
                        MessageBox.Show(" خطایی رخ داده است");
                    }

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Owner.Show();
        }

       






















        //---End Block of Class And Namespace------------------------
    }
}
