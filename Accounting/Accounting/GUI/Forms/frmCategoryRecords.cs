using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces.IRepositories;
using Accounting.Utilities;
using AccountingDLL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Accounting.GUI.Forms
{
    public partial class frmCategoryRecords : Form
    {
        public frmCategoryRecords()
        {
            InitializeComponent(); 
            setDataGridViewSettings(DGV1);
        }
        public string _CategoryName;
      

        void setDataGridViewSettings(DataGridView dataGridView)
        {
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.ColumnHeadersHeight = 50;
            DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
            Font font = new Font("Microsoft Sans Serif", 12);

            dataGridViewCellStyle.Font = font;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
            dataGridView.ColumnHeadersHeight = 50;
            dataGridView.Dock = DockStyle.Right;
            dataGridView.RowHeadersWidth = 30;
            dataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView.RowsDefaultCellStyle.Font = font;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Size size = new Size();
            size.Width = 800;
            size.Height = 600;

            dataGridView.Size = size;

        }
        async void LoadData()
        {
            using (UnitOfWork _UnitOfWork = new UnitOfWork())
            {
                ICategoryRepository _CategoryRepository = _UnitOfWork.CategoryRepository;

                //--------
                IEnumerable<Category> IenamrableCategoryDbRecords = await _CategoryRepository.GetAll<Category>(n => n == n);
                DGV1.DataSource = IenamrableCategoryDbRecords;

                DGV1.Columns["Row"].HeaderText = " ردیف";
                DGV1.Columns["CategoryCode"].HeaderText = " کد دسته";
                DGV1.Columns["CategoryName"].HeaderText = " نام دسنه";
                //----------------------------------





            }
        }


        private void frmCategoryRecords_Load(object sender, EventArgs e)
        {

            LoadData();
        }





        async private void txtCategoryId_TextChanged(object sender, EventArgs e)
        {

            if (txtCategoryId.Text == "")
            {
                LoadData();
                return;
            }
            bool ValidationResult = WorkWithStrings.StringToIntValidations(txtCategoryId.Text);
            if (!ValidationResult)
            {
                // MessageBox.Show("فیلد کد باید عددی صحیح باشد ");
                txtCategoryId.Text = "";
                return;
            }




            using (UnitOfWork _UnitOfWork = new UnitOfWork())
            {
                ICategoryRepository _CategoryRepository = _UnitOfWork.CategoryRepository;
                try
                {


                    long CategoryId = long.Parse(txtCategoryId.Text);
                    var CategoriesDbRecords = await _CategoryRepository.GetAll<Category>(n => n.Row.ToString().Contains(CategoryId.ToString()));
                    DGV1.DataSource = CategoriesDbRecords;


                }
                catch
                {
                    MessageBox.Show(" خطایی رخ داده است");
                }


            }
        }

        async private void txtCategoryName_TextChanged(object sender, EventArgs e)
        {
            if (txtCategoryName.Text == "")
            {
                LoadData();
                return;
            }



            using (UnitOfWork _UnitOfWork = new UnitOfWork())
            {
                ICategoryRepository _CategoryRepository = _UnitOfWork.CategoryRepository;
                //try
                //{


                var CategoriesDbRecords = await _CategoryRepository.GetAll<Category>(n => n.CategoryName.Contains(txtCategoryName.Text));
                DGV1.DataSource = CategoriesDbRecords;


                //}
                //catch
                //{
                //    MessageBox.Show(" خطایی رخ داده است");
                //}


            }
        }

        private void DGV1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _CategoryName = DGV1.Rows[e.RowIndex].Cells["CategoryName"].Value.ToString();
            this.DialogResult = DialogResult.OK;
        }



        private void frmCategoryRecords_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnExcelExport_Click(object sender, EventArgs e)
        {
            WorkWithExcel.ExportExcel(DGV1);
        }





























        //------------------------------------------
    }
}
