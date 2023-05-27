using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces;
using Accounting.DataLayer.Services;
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

                        foreach (var n in _CompanyRepository.GetAll<Company>(n=>n==n))
                        {
                            cbCompany.Items.Add(n.CompanyName);
                        }

                        foreach (var n in _CategoryRepository.GetAll<Category> (n=>n==n))
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
            bunifuCircleProgress1.Value = 0;
            bunifuCircleProgress2.Value = 0;
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


            
            productRecord.id = Convert.ToInt32(txtProductCode.Text);
            productRecord.ProductName = txtProductName.Text;
            productRecord.Price = Convert.ToDecimal(txtPrice.Text);
            productRecord.Company = cbCompany.Text;
            productRecord.Category = cbCategory.Text;
            productRecord.Features = txtFeatures.Text;
            productRecord.Picture = WorkWithImage.imageToByteArray(PboxProductPicture.Image);
            return productRecord;



        }
        private void FillControlersWithProductDbRecord(Product dbProductRecord)
        {
            try
            {


                txtProductCode.Text = dbProductRecord.id.ToString();
                txtProductName.Text = dbProductRecord.ProductName;
                txtPrice.Text = dbProductRecord.Price.ToString();
                cbCompany.Text = dbProductRecord.Company;
                cbCategory.Text = dbProductRecord.Category;
                txtFeatures.Text = dbProductRecord.Features;
                PboxProductPicture.Image = WorkWithImage.byteArrayToImage(dbProductRecord.Picture);
            }
            catch
            {
                MessageBox.Show("خطایی رخ داده است");
            }
          



        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Reset();
        }



        private async void btnSave_Click(object sender, EventArgs e)
        {
            bunifuCircleProgress2.Value = 0;
            bunifuCircleProgress2.Value += 10;
            try
            {
                bunifuCircleProgress2.Value += 10;
                using (UnitOfWork _UnitOfWork = new UnitOfWork())
                {
                    bunifuCircleProgress2.Value += 10;
                    IProductRepository _ProductRepository = _UnitOfWork.ProductRepository;
                    if (!IsNull())
                    {
                        bunifuCircleProgress2.Value += 10;
                        int productCode = Int32.Parse(txtProductCode.Text);
                        bool Result = /*await*/ _ProductRepository.IsExist<Product>(n=>n.id== productCode);
                        bunifuCircleProgress2.Value += 10;
                        if (!Result)
                        {
                            bunifuCircleProgress2.Value += 10;
                            Product ProductRecord = new Product();
                                ProductRecord = Fill__ProductRecord(ProductRecord);
                            bunifuCircleProgress2.Value += 10;
                            if (_ProductRepository.Add<Product>(ProductRecord))
                                {
                                bunifuCircleProgress2.Value += 10;
                                MessageBox.Show("رکورد با موفقیت ثبت شد");
                                bunifuCircleProgress2.Value += 10;
                                _UnitOfWork.Save();
                                Reset();
                                bunifuCircleProgress2.Value += 10;
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

    


        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("آیا از حذف رکورد اطمینان دارید ؟", "تایید کردن", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    using (UnitOfWork _unitOfWork = new UnitOfWork())
                    {

                        IProductRepository _ProductRepository = _unitOfWork.ProductRepository;
                   
                       
                        int ProductCode = Convert.ToInt32(txtProductCode.Text);
                        bool result = /*await*/ _ProductRepository.IsExist<Product>(N=>N.id== ProductCode);
                        if (result)
                        {
                          bool DeleteResult= await _ProductRepository.DeleteByCondition<Product>(n => n.id == ProductCode);
                            if (DeleteResult)
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
                        int ProductCode = Convert.ToInt32(txtProductCode.Text);
                        if (_ProductRepository.UpdateProduct(Instance,n=>n.id== Instance.id))
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
            frmProductRecords frm = new frmProductRecords(this);
            frm.ShowDialog();
            this.Hide();
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            Reset();
            FillCombo();
            txtProductName.Focus();
        }

        private async void btnGetDetails_Click(object sender, EventArgs e)
        {
            bunifuCircleProgress1.Value = 0;
            bunifuCircleProgress1.Value += 10;
            bunifuCircleProgress1.Value += 10;
            try 
            {
                bunifuCircleProgress1.Value += 10;
                using (UnitOfWork _unitOfWork = new UnitOfWork())
                {
                    bunifuCircleProgress1.Value += 10;
                    IProductRepository _ProductRepository = _unitOfWork.ProductRepository;
                    bunifuCircleProgress1.Value += 10;
                    int ProductCode = Int32.Parse(txtProductCode.Text);
                    bunifuCircleProgress1.Value += 10;
                    bool result = /*await*/ _ProductRepository.IsExist<Product>(n=>n.id== ProductCode);
                    bunifuCircleProgress1.Value += 10;
                    if (result)
                    {
                        bunifuCircleProgress1.Value += 10;
                        Product record = _ProductRepository.GetEntity<Product>(n=>n.id== ProductCode);
                        FillControlersWithProductDbRecord(record);
                        bunifuCircleProgress1.Value += 20;


                    }
                    else
                    {
                        MessageBox.Show("محصولی با این کد وجود ندارد");
                        Reset();
                    }






                }


            }
            catch
            {
                MessageBox.Show("خطایی رخ داده است");
            }
        }

    

        private void txtProductCode_TextChanged(object sender, EventArgs e)
        {
            bool ValidationResult = WorkWithStrings.TextToIntVlaidation(txtProductCode.Text);
            if (!ValidationResult)
            {
                // MessageBox.Show("فیلد کد باید عددی صحیح باشد ");
                txtProductCode.Text = "";
                return;
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bunifuFormDock1_FormDragging(object sender, Bunifu.UI.WinForms.BunifuFormDock.FormDraggingEventArgs e)
        {

        }




















        //---End Block of Class And Namespace------------------------

    }
}
