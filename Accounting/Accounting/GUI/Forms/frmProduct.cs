using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces;
using Accounting.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting.GUI.Forms
{
    public partial class frmProduct : Form
    {
        //------------Fields----------------



        //------------Methods----------------
        public frmProduct()
        {
            InitializeComponent();
        }

        void FillCombo()
        {
            try
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
            catch
            {
                MessageBox.Show("خطایی رخ داده است");
            }


        }
        private void Reset()
        {
            txtPrice.Text = "";
            txtFeatures.Text = "";
            txtProductCode.Text = "";
            txtProductName.Text = "";
            cbCategory.Text = "";
            cbCompany.Text = "";
            PboxProductPicture.Image = null;
            PboxProductPicture.Image = Properties.Resources.icons8_product_128px_2;
            txtProductName.Focus();
        }

        private bool IsNull()
        {
            if (txtPrice.Text == "" ||
                txtFeatures.Text == "" ||
               txtProductName.Text == "" ||
               txtProductCode.Text == "" ||
               cbCategory.Text == "" ||
               cbCompany.Text == "")

                return true;
            else
            {
                return false;
            }

        }

        private Product Fill__ProductRecord(Product productRecord)
        {



            productRecord.ProductId = Convert.ToInt32(txtProductCode.Text);
            productRecord.ProductName = txtProductName.Text;
            productRecord.Price = Convert.ToDouble(txtPrice.Text);
            productRecord.Company = cbCompany.Text;
            productRecord.Category = cbCategory.Text;
            productRecord.Features = txtFeatures.Text;
            productRecord.Picture = WorkWithImage.imageToByteArray(PboxProductPicture.Image);
            return productRecord;



        }


        private void btnNew_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            Reset();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                using (UnitOfWork _UnitOfWork = new UnitOfWork())
                {
                    IProductRepository _ProductRepository = _UnitOfWork.ProductRepository;
                    if (!IsNull())
                    {
                        bool Result = await _ProductRepository.ProductExist(Int32.Parse(txtProductCode.Text));
                        if (!Result)
                        {
                            //using (UnitOfWork _unitOfWork = new UnitOfWork())
                            //{
                            Product ProductRecord = new Product();
                            ProductRecord = Fill__ProductRecord(ProductRecord);

                            if (_ProductRepository.InsertToProduct(ProductRecord))
                            {
                                MessageBox.Show("رکورد با موفقیت ثبت شد");

                                _UnitOfWork.Save();
                                Reset();
                            }
                            else
                            {
                                MessageBox.Show("خطایی رخ داده است");
                            }
                        }
                        else
                        {
                            MessageBox.Show("این محصول از قبل وجود دارد");
                            Reset();
                        }
                    }
                    else
                    {
                        MessageBox.Show("لطفا فیلد های خواسته شده را پر کنید");

                    }
                }
            }
            catch
            {
                MessageBox.Show("خطایی رخ داده است");
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {

            try
            {
                OpenFileDialog OFD = new OpenFileDialog();

                OFD.Filter = ("Image Files |*.png; *.bmp; *.jpg;*.jpeg; *.gif;");
                OFD.FilterIndex = 4;
                //Reset the file name
                OFD.FileName = "";

                if (OFD.ShowDialog() == DialogResult.OK)
                {
                    PboxProductPicture.Image = Image.FromFile(OFD.FileName);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("آیا از حذف رکورد اطمینان دارید ؟", "تایید کردن", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (UnitOfWork _unitOfWork = new UnitOfWork())
                    {
                        IProductRepository _ProductRepository = _unitOfWork.ProductRepository;

                        bool result = await _ProductRepository.ProductExist(Int32.Parse(txtProductCode.Text));
                        if (result)
                        {
                            if (_ProductRepository.DeleteProductRecord(Int32.Parse(txtProductCode.Text)))
                                MessageBox.Show("رکورد با موفقیت حذف شد");
                            _unitOfWork.Save();
                            Reset();


                        }
                        else
                        {
                            MessageBox.Show("خطایی رخ داده است");
                        }






                    }

                }
            }
            catch
            {
                MessageBox.Show("خطایی رخ داده است");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsNull())
                {
                    using (UnitOfWork _unitOfWork = new UnitOfWork())
                    {
                        IProductRepository _ProductRepository = _unitOfWork.ProductRepository;
                        Product Instance = new Product();
                        Instance = Fill__ProductRecord(Instance);
                        if (_ProductRepository.UpdateRecord(Instance))
                        {
                            MessageBox.Show("رکورد با موفقیت  بروز شد");
                            _unitOfWork.Save();
                            Reset();
                        }
                        else
                        {
                            MessageBox.Show("خطایی رخ داده است");
                        }

                    }
                }
                else
                {
                    MessageBox.Show("لطفا فیلد های خواسته شده را پر کنید");
                }
            }
            catch
            {
                MessageBox.Show("خطایی رخ داده است");
            }
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            frmProductRecords frm = new frmProductRecords();
            frm.ShowDialog();
            this.Hide();
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            FillCombo();
            txtProductName.Focus();
        }



















        //---End Block of Class And Namespace------------------------

    }
}
