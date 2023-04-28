using Accounting.DataLayer.Context;
using Accounting.DataLayer.Interfaces;
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

        private void frmProductRecords_Load(object sender, EventArgs e)
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

        private void txtProductName_TextChanged(object sender, EventArgs e)
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

        private void txtCompany_TextChanged(object sender, EventArgs e)
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

        private void txtCategory_TextChanged(object sender, EventArgs e)
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
            int rowsTotal = 0;
            int colsTotal = 0;
            int I = 0;
            int j = 0;
            int iC = 0;
            Cursor.Current = Cursors.WaitCursor;
            Excel.Application _ExcelApplication = new Excel.Application();

            try
            {
                Excel.Workbook ExcelBook = _ExcelApplication.Workbooks.Add();
                Excel.Worksheet ExcelWorksheet = ExcelBook.Worksheets[1];
                _ExcelApplication.Visible = true;

                rowsTotal = DGV1.RowCount;
                colsTotal = DGV1.Columns.Count - 1;
                var _ExcelWorksheet = ExcelWorksheet;

                for (iC = 0; iC <= colsTotal; iC++)
                {
                    _ExcelWorksheet.Cells[1, iC + 1].Value = DGV1.Columns[iC].HeaderText;
                }
                for (I = 0; I <= rowsTotal - 1; I++)
                {
                    for (j = 0; j <= colsTotal; j++)
                    {
                        _ExcelWorksheet.Cells[I + 2, j + 1].value = DGV1.Rows[I].Cells[j].Value;
                    }
                }


                _ExcelWorksheet.Cells.Columns.AutoFit();
                _ExcelWorksheet.Cells.Select();
                _ExcelWorksheet.Cells.EntireColumn.AutoFit();
                _ExcelWorksheet.Cells[1, 1].Select();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

                Cursor.Current = Cursors.Default;
                _ExcelApplication = null;
            }
        }
    }
}
