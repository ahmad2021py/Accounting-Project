using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
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








        private void btnSave_Click(object sender, EventArgs e)
        {
            if (WorkWithTextboxes.TextBoxisNull(txtCategoryName.Text))
            {

                MessageBox.Show("لطفا نام دسته بندی را مشخص کنید");

            }
            else
            {

                using (UnitOfWork _UnitOfWork = new UnitOfWork())
                {
                    ICategoryRepository _CategoryRepository = _UnitOfWork.CategoryRepository;
                    if (_CategoryRepository.CategoryExist(txtCategoryName.Text))
                    {
                        MessageBox.Show("این دسته بندی از قبل وجود دارد");
                    }
                    else
                    {
                        Categories Record = new Categories();
                        Record.CategoryName = txtCategoryName.Text;
                        if (_CategoryRepository.InsertToCategory(Record))
                        {
                            MessageBox.Show("شرکت با موفقیت اضافه شد");
                            txtCategoryName.Text = "";

                        }

                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا از حذف رکورد اطمینان دارید ؟", "تایید کردن", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                using (UnitOfWork _unitOfWork = new UnitOfWork())
                {
                    ICategoryRepository _CategoryRepository = _unitOfWork.CategoryRepository;


                    if (_CategoryRepository.CategoryExist(txtCategoryName.Text))
                    {
                        if (_CategoryRepository.DeleteCategory(txtCategoryName.Text))
                            MessageBox.Show("رکورد با موفقیت حذف شد");
                        Reset();

                    }
                    else
                    {
                        MessageBox.Show("خطایی رخ داده است");
                    }






                }

            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            frmCategoryRecords frm = new frmCategoryRecords();
            frm.ShowDialog();
        }
    }
}
