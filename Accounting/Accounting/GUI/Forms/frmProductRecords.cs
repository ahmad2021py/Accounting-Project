using Accounting.DataLayer.Context;
using Accounting.DataLayer.Interfaces;
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
using Excel = Microsoft.Office.Interop.Excel;

namespace Accounting.GUI.Forms
{
    public partial class frmProductRecords : Form
    {
        public frmProductRecords()
        {
            InitializeComponent();
        }

        void LoadData()
        {
            using (UnitOfWork _UnitOfWork = new UnitOfWork())
            {
                IProductRepository _ProductRepository = _UnitOfWork.ProductRepository;
                try
                {
                    DGV1.DataSource = _ProductRepository.GetProductList();
                    DGV1.Columns[0].HeaderText = " کد محصول";
                    DGV1.Columns[1].HeaderText = " نام محصول";
                    DGV1.Columns[2].HeaderText = " دسته بندی";
                    DGV1.Columns[3].HeaderText = " شرکت";
                }
                catch
                {
                    MessageBox.Show(" خطایی رخ داده است");
                }
            }
        }
        private void frmProductRecords_Load(object sender, EventArgs e)
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
                        DGV1.DataSource = _ProductRepository.GetProductListByProductNameFilter(txtProductName.Text);

                    }
                    catch
                    {
                        MessageBox.Show(" خطایی رخ داده است");
                    }

                }
            }
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
                        DGV1.DataSource = _ProductRepository.GetProductListByCompanyFilter(txtCompany.Text);

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
                        DGV1.DataSource = _ProductRepository.GetProductListByCategoryFilter(txtCategory.Text);

                    }
                    catch
                    {
                        MessageBox.Show(" خطایی رخ داده است");
                    }
                }
            }
        }

     

        
      

        private void DGV1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow dr = DGV1.SelectedRows[0];
                frmProduct frm = new frmProduct();
                this.Hide();
                frm.txtProductName.Text = dr.Cells[1].Value.ToString();
                frm.cbCategory.Text = dr.Cells[2].Value.ToString();
                frm.cbCompany.Text = dr.Cells[3].Value.ToString();
                frm.btnUpdate.Enabled = true;
                frm.btnDelete.Enabled = true;
                
               
                frm.ShowDialog();
                frm.txtProductName.Focus();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            WorkWithExcel.ExportExcel(DGV1);
        }
    }
}
