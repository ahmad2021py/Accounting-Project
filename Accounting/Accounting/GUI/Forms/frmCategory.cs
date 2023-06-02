using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces.IRepositories;
using System;
using System.Windows.Forms;

namespace Accounting.GUI.Forms
{
    public partial class frmCategory : Form
    {
        public frmCategory()
        {
            InitializeComponent();
        }

        void Reset()
        {
            txtCategoryName.Text = "";
            // btnSave.Enabled = true;
            // btnDelete.Enabled = false;
            txtCategoryName.Focus();

        }














        private void frmCategory_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Reset();
        }



        async private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCategoryName.Text) || string.IsNullOrWhiteSpace(txtCategoryName.Text))
            {

                MessageBox.Show("ورودی نامعتبر");
                return;
            }

            using (UnitOfWork _UnitOfWork = new UnitOfWork())
            {
                ICategoryRepository _CategoryRepository = _UnitOfWork.CategoryRepository;
                bool result = await _CategoryRepository.IsExist<Category>(n => n.CategoryName == txtCategoryName.Text);
                if (result)
                {
                    MessageBox.Show("این دسته بندی از قبل وجود دارد");
                    return;
                }

                Category Record = new Category();
                Record.CategoryName = txtCategoryName.Text;
                bool AddRresult = await _CategoryRepository.Add<Category>(Record);
                if (!AddRresult)
                {
                    MessageBox.Show("در افزودن مورد خطایی رخ داده");
                    return;

                }


                try
                {
                    _UnitOfWork.Save();

                }

                catch
                {
                    MessageBox.Show("در ذخیره تغییرات خطایی رخ داده است");
                }

                MessageBox.Show("دسته بندی  با موفقیت اضافه شد");
                txtCategoryName.Text = "";



            }
        }


        private void btnShowfrmCategoryRecords_Click(object sender, EventArgs e)
        {
            txtCategoryName.Text = "";
            frmCategoryRecords frmCategoryRecords = new frmCategoryRecords();
            if (frmCategoryRecords.ShowDialog() == DialogResult.OK)
            {

                frmCategoryRecords.Close();
                txtCategoryName.Text = frmCategoryRecords._CategoryName;
                frmCategoryRecords = null;

            }
        }

        async private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCategoryName.Text) || string.IsNullOrWhiteSpace(txtCategoryName.Text))
            {

                MessageBox.Show("ورودی نامعتبر");
                return;
            }
            if (MessageBox.Show("آیا از حذف رکورد اطمینان دارید ؟", "تایید کردن", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (UnitOfWork _unitOfWork = new UnitOfWork())
                {
                    ICategoryRepository _CategoryRepository = _unitOfWork.CategoryRepository;

                    bool Result = await _CategoryRepository.IsExist<Category>(n => n.CategoryName == txtCategoryName.Text);
                    if (!Result)
                    {
                        MessageBox.Show("دسته بندی با این نام وجود ندارد");
                        Reset();
                        return;
                    }
                    bool result = await _CategoryRepository.DeleteByCondition<Category>(n => n.CategoryName == txtCategoryName.Text);
                    if (!result)
                    {
                        MessageBox.Show("خطایی هنگام حذف مورد رخ داده است");
                        return;

                    }

                    MessageBox.Show("رکورد با موفقیت حذف شد");
                    _unitOfWork.Save();
                    Reset();
                }

            }
        }

















        //-----------------
    }
}
