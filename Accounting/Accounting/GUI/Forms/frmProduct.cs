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
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
        }

        Product Fill_ProductInstance(Product Instance)
        {



            Instance.ProductName = txtProductName.Text;
            Instance.Category = cbCategory.Text;
            Instance.Company = cbCompany.Text;

            return Instance;
        }



        void Reset()
        {
            txtProductName.Text = "";
            cbCompany.Text = "";
            cbCategory.Text = "";



        }
        void FillCombo()
        {
            using (UnitOfWork _UnitOfWork = new UnitOfWork())
            {
                ICompanyRepository _CompanyRepository = _UnitOfWork.CompanyRepository;
                ICategoryRepository _CategoryRepository = _UnitOfWork.CategoryRepository;
                try
                {

                    foreach (var n in _CompanyRepository.GetCompanyList())
                    {
                        cbCompany.Items.Add(n.CompanyName);
                    }

                    foreach (var n in _CategoryRepository.GetCategoryList())
                    {
                        cbCategory.Items.Add(n.CategoryName);
                    }

                }
                catch
                {
                    MessageBox.Show(" خطایی رخ داده است");
                }



            }

        }
        private void frmProduct_Load(object sender, EventArgs e)
        {
            FillCombo();
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            frmProductRecords frm = new frmProductRecords();
            this.Hide();
            frm.ShowDialog();


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (WorkWithTextboxes.TextBoxisNull(txtProductName.Text))
            {

                MessageBox.Show(" لطفا نام محصول را مشخص کنید");

            }
            else if (WorkWithTextboxes.TextBoxisNull(cbCompany.Text))
            {
                MessageBox.Show(" لطفا شرکت سازنده محصول را مشخص کنید");


            }
            else if (WorkWithTextboxes.TextBoxisNull(cbCategory.Text))
            {
                MessageBox.Show(" لطفا دسته بندی محصول را مشخص کنید");


            }
            else
            {

                using (UnitOfWork _UnitOfWork = new UnitOfWork())
                {
                    IProductRepository _ProductRepository = _UnitOfWork.ProductRepository;
                    if (_ProductRepository.ProductExist(txtProductName.Text))
                    {
                        MessageBox.Show("این محصول از قبل وجود دارد");
                    }
                    else
                    {
                        Product Record = new Product();
                        Record.ProductName = txtProductName.Text;
                        Record.Category = cbCategory.Text;
                        Record.Company = cbCompany.Text;

                        if (_ProductRepository.InsertToProduct(Record))
                        {
                            MessageBox.Show("محصول با موفقیت اضافه شد");
                            txtProductName.Text = "";
                            cbCategory.Text = "";
                            cbCompany.Text = "";

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
                    IProductRepository _ProductRepository = _unitOfWork.ProductRepository;


                    if (_ProductRepository.ProductExist(txtProductName.Text))
                    {
                        if (_ProductRepository.DeleteProduct(txtProductName.Text))
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (UnitOfWork _unitOfWork = new UnitOfWork())
            {
                IProductRepository _ProductRepository = _unitOfWork.ProductRepository;
                Product Instance = new Product();
                Instance = Fill_ProductInstance(Instance);
                if (_ProductRepository.UpdateRecord(Instance))
                {
                    MessageBox.Show("رکورد با موفقیت  بروز شد");
                    Reset();
                }
                else
                {
                    MessageBox.Show("خطایی رخ داده است");
                }

            }
        }
    }
}
