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

        async void FillCombo()
        {
            //try
            //{


                using (UnitOfWork _UnitOfWork = new UnitOfWork())
                {
                    ICompanyRepository _CompanyRepository = _UnitOfWork.CompanyRepository;
                    ICategoryRepository _CategoryRepository = _UnitOfWork.CategoryRepository;
                   
                        var CompanyDbList = await _CompanyRepository.GetAll<Company>(n => n == n);
                        var CategoryDbList = await _CategoryRepository.GetAll<Category>(n => n == n);
                        foreach (var n in CompanyDbList)
                        {
                            cbCompany.Items.Add(n.CompanyName);
                        }

                        foreach (var n in CategoryDbList)
                        {
                            cbCategory.Items.Add(n.CategoryName);
                        }

                   
                }



            //}
            //catch
            //{
            //    MessageBox.Show("خطایی رخ داده است");
            //}


        }
        private void Reset()
        {
          
            txtPrice.Text = "";
            txtFeatures.Text = "";
            txtProductCode.Text = "";
            txtProductName.Text = "";
            cbCategory.Text = "";
            cbCompany.Text = "";
            txtCountingUnit.Text = "";
            PboxProductPicture.Image = null;
            PboxProductPicture.Image = Properties.Resources.icons8_product_128px_2;

            txtProductName.Focus();
        }

        private bool IsNull()
        {
            if (
               string.IsNullOrEmpty(txtFeatures.Text) ||
                  string.IsNullOrEmpty(txtPrice.Text) ||
                  string.IsNullOrEmpty(txtCountingUnit.Text) ||
                  string.IsNullOrEmpty(txtProductCode.Text) ||
                  string.IsNullOrEmpty(txtFeatures.Text) ||
                  string.IsNullOrWhiteSpace(txtPrice.Text) ||
                  string.IsNullOrWhiteSpace(txtCountingUnit.Text) ||
                  string.IsNullOrWhiteSpace(cbCategory.Text) ||
                  string.IsNullOrWhiteSpace(cbCompany.Text) 
                  )



               

                return true;
            else
            {
                return false;
            }

        }

        private Product Fill__ProductRecord(Product productRecord)
        {



            productRecord.ProductCode = Convert.ToInt32(txtProductCode.Text);
            productRecord.CountingUnit =txtCountingUnit.Text;
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


               
                txtProductName.Text = dbProductRecord.ProductName;
                txtPrice.Text = dbProductRecord.Price.ToString();
                cbCompany.Text = dbProductRecord.Company;
                cbCategory.Text = dbProductRecord.Category;
                txtCountingUnit.Text = dbProductRecord.CountingUnit;
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








       async private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (IsNull())
            {
                MessageBox.Show("ورودی یا ورودی های نامعتبر", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
          

                    using (UnitOfWork _unitOfWork = new UnitOfWork())
                    {
                     
                        IProductRepository _ProductRepository = _unitOfWork.ProductRepository;
                 
                        Product Instance = new Product();
                        Instance = Fill__ProductRecord(Instance);
                        int ProductCode = Convert.ToInt32(txtProductCode.Text);
                    
                        bool UpdateProductResult = await _ProductRepository.UpdateProduct(Instance, n => n.ProductCode == Instance.ProductCode);
                        if (UpdateProductResult)
                        {
                           
                            MessageBox.Show("رکورد با موفقیت  بروز شد");
                      
                            _unitOfWork.Save();
                        
                            Reset();
                        }
                        else
                        {
                   
                            MessageBox.Show("خطایی رخ داده است");
                     
                            return;
                        }

                    }
              
            //}
            //catch
            //{
            //    bunifuCircleProgress3.ProgressColor = Color.Red;
            //    MessageBox.Show("خطایی رخ داده است");
            //    bunifuCircleProgress3.Value = 0;
            //    return;
            //}
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
            if (string.IsNullOrEmpty(txtProductCode.Text)|| string.IsNullOrWhiteSpace(txtProductCode.Text))
            {
                MessageBox.Show("ورودی نامعتبر");
                return;
            }
                
                using (UnitOfWork _unitOfWork = new UnitOfWork())
            {

                IProductRepository _ProductRepository = _unitOfWork.ProductRepository;

                int ProductCode = Int32.Parse(txtProductCode.Text);

                bool result = await _ProductRepository.IsExist<Product>(n => n.ProductCode == ProductCode);

                if (result)
                {

                    Product record = await _ProductRepository.GetEntity<Product>(n => n.ProductCode == ProductCode);
                    FillControlersWithProductDbRecord(record);



                }
                else
                {

                    MessageBox.Show("محصولی با این کد وجود ندارد");
                    Reset();

                }






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

        private void frmProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

      async  private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsNull())
            {
                MessageBox.Show("ورودی یا ورودی های نامعتبر", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //try
            //{

            using (UnitOfWork _UnitOfWork = new UnitOfWork())
            {

                IProductRepository _ProductRepository = _UnitOfWork.ProductRepository;
               
                    int productCode = Int32.Parse(txtProductCode.Text);
                    bool Result = await _ProductRepository.IsExist<Product>(n => n.ProductCode == productCode);

                    if (!Result)
                    {

                        Product ProductRecord = new Product();
                        ProductRecord = Fill__ProductRecord(ProductRecord);

                        bool AddResult = await _ProductRepository.Add<Product>(ProductRecord);
                        if (AddResult)
                        {

                            MessageBox.Show("رکورد با موفقیت ثبت شد");

                            _UnitOfWork.Save();

                            Reset();

                        }
                        else
                        {

                            MessageBox.Show("خطایی رخ داده است");

                            return;
                        }
                    }
                    else
                    {

                        MessageBox.Show("این محصول از قبل وجود دارد");

                        Reset();
                        return;
                    }
                }
             
            
            //}
            //catch
            //{
            //    bunifuCircleProgress2.ProgressColor = Color.Red;
            //    MessageBox.Show("خطایی رخ داده است");
            //    bunifuCircleProgress2.Value = 0;
            ////    return;
            //}
        }

      async  private void btnDelete_Click(object sender, EventArgs e)
        {
            if (IsNull())
            {
                MessageBox.Show("ورودی یا ورودی های نامعتبر", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("آیا از حذف رکورد اطمینان دارید ؟", "تایید کردن", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {

                using (UnitOfWork _unitOfWork = new UnitOfWork())
                {


                    IProductRepository _ProductRepository = _unitOfWork.ProductRepository;


                    int ProductCode = Convert.ToInt32(txtProductCode.Text);

                    bool result = await _ProductRepository.IsExist<Product>(N => N.ProductCode == ProductCode);
                    if (result)
                    {

                        bool DeleteResult = await _ProductRepository.DeleteByCondition<Product>(n => n.ProductCode == ProductCode);

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
            //}
            //catch
            //{
            //    bunifuCircleProgress4.ProgressColor = Color.Red;
            //    MessageBox.Show("خطایی رخ داده است");
            //    bunifuCircleProgress4.Value = 0;
            //}
        }

        private void btnShowfrmProductRecords_Click(object sender, EventArgs e)
        {
            frmProductRecords formProductRecords = new frmProductRecords(this);
            if (formProductRecords.ShowDialog() == DialogResult.OK)
            {

                formProductRecords.Close();
                this.cbCategory.Text = formProductRecords._Category;
                this.cbCompany.Text = formProductRecords._Company;
                this.txtFeatures.Text = formProductRecords._Features;
                this.txtProductCode.Text = formProductRecords._ProductCode;
                this.PboxProductPicture.Image = formProductRecords._Picture;
                this.txtPrice.Text = formProductRecords._Price;
                this.txtProductName.Text = formProductRecords._ProductName;
                formProductRecords = null;



            }
        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFeatures_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnShowProductSoldRecords_Click(object sender, EventArgs e)
        {
            frmProductsSoldRecords frmProductsSoldRecords = new frmProductsSoldRecords();
            if (frmProductsSoldRecords.ShowDialog() == DialogResult.OK)
            {

                frmProductsSoldRecords.Close();

                frmProductsSoldRecords = null;



            }
        }

























        //---End Block of Class And Namespace------------------------

    }
}
