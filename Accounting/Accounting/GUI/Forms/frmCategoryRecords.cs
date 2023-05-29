using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces;
using Accounting.Utilities;
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

namespace Accounting.GUI.Forms
{
    public partial class frmCategoryRecords : Form
    {
        public frmCategoryRecords()
        {
            InitializeComponent();
        }

     async   void LoadData()
        {
            using (UnitOfWork _UnitOfWork = new UnitOfWork())
            {
                ICategoryRepository _CategoryRepository = _UnitOfWork.CategoryRepository;
                try
                {
                    //--------
                    IEnumerable<Category>IenamrableCategoryDbRecords = await _CategoryRepository.GetAll<Category>(n => n == n);
                    DGV1.DataSource = IenamrableCategoryDbRecords;
                    DGV1.Columns["id"].HeaderText = " کد دسته";
                    DGV1.Columns["CategoryName"].HeaderText = " نام دسنه";
                    //----------------------------------


                }
                catch
                {
                    MessageBox.Show(" خطایی رخ داده است");
                }
            }
        }


        private  void frmCategoryRecords_Load(object sender, EventArgs e)
        {

            LoadData();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            WorkWithExcel.ExportExcel(DGV1);
        }

 
           

        private void txtCategoryId_TextChanged(object sender, EventArgs e)
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
                        DGV1.DataSource = _CategoryRepository.GetAll<Category>(n => n.id.ToString().Contains(CategoryId.ToString()) );
                       

                    }
                    catch
                    {
                        MessageBox.Show(" خطایی رخ داده است");
                    }

                
            }
        }

        private void txtCategoryName_TextChanged(object sender, EventArgs e)
        {
            if (txtCategoryName.Text == "")
            {
                LoadData();
            }


            else
            {
                using (UnitOfWork _UnitOfWork = new UnitOfWork())
                {
                    ICategoryRepository _CategoryRepository = _UnitOfWork.CategoryRepository;
                    try
                    {


                      
                        DGV1.DataSource = _CategoryRepository.GetAll<Category>(n => n.CategoryName.Contains(txtCategoryName.Text) );


                    }
                    catch
                    {
                        MessageBox.Show(" خطایی رخ داده است");
                    }

                }
            }
        }

        private void DGV1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow dr = new DataGridViewRow();


                frmCategory obj = new frmCategory();


                obj.txtCategoryName.Text = dr.Cells["CategoryName"].Value.ToString();

                obj.Show();
                this.Close();
            }
            catch
            {
                MessageBox.Show("خطایی رخ داده");
            }

        }

        private void frmCategoryRecords_FormClosed(object sender, FormClosedEventArgs e)
        {
           
            this.Hide();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void frmCategoryRecords_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

























        //------------------------------------------
    }
}
