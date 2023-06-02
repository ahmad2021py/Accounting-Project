using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces.IRepositories;
using Accounting.Utilities;
using AccountingDLL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Accounting.GUI.Forms
{
    public partial class frmCategoryRecords : Form
    {
        public frmCategoryRecords()
        {
            InitializeComponent();
        }
        public string _CategoryName;
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
            bool ValidationResult = WorkWithStrings.TextToIntVlaidation(txtCategoryId.Text);
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
