using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces.IRepositories;
using Accounting.Utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
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
            txtFeatures.Text = "";
            txtProductCode.Text = "";
            txtProductName.Text = "";
            cbCategory.Text = "";
            cbCompany.Text = "";
            PboxProductPicture.Image = Properties.Resources.icons8_product_128px_2;

            txtProductName.Focus();
        }










        private Product Fill__ProductRecord(Product productRecord)
        {



            productRecord.ProductCode = Convert.ToInt32(txtProductCode.Text);
            productRecord.ProductName = txtProductName.Text;
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








        async private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool isNull = WorkWithStrings.StringIsNullOrEmptyOrWhiteSpace(cbCompany.Text, cbCategory.Text, txtFeatures.Text, txtProductCode.Text);
            if (isNull)
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


                //------Fill PropertyMap ------------

                List<PropertyMap> ProductPropertiesToUpdate = new List<PropertyMap> {

                new PropertyMap()
                {
                    PropertyName ="Company" ,
                    PropertyValue= cbCompany.Text,


                } ,
                new PropertyMap()
                {

                    PropertyName = "Picture" ,
                    PropertyValue= WorkWithImage.imageToByteArray(PboxProductPicture.Image)


                 } ,

                 new PropertyMap()
                {

                    PropertyName = "ProductName" ,
                    PropertyValue= txtProductName.Text


                      } ,
                    new PropertyMap()
                     {

                    PropertyName = "Category" ,
                    PropertyValue= cbCategory.Text


                    } ,
                    new PropertyMap()
                     {

                    PropertyName = "Features" ,
                    PropertyValue= txtFeatures.Text ,


                    } ,

                };
                //-----

                int productCode = int.Parse(txtProductCode.Text);

                bool UpdateProductResult = await _ProductRepository.UpdateMany<Product>(n => n.ProductCode == productCode, ProductPropertiesToUpdate);

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
            if (WorkWithStrings.StringIsNullOrEmptyOrWhiteSpace(txtProductCode.Text))
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
            bool ValidationResult = WorkWithStrings.StringToIntValidations(txtProductCode.Text);
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

        async private void btnSave_Click(object sender, EventArgs e)
        {

            bool isNull = WorkWithStrings.StringIsNullOrEmptyOrWhiteSpace(cbCompany.Text
                , cbCategory.Text, txtFeatures.Text, txtProductCode.Text);
            if (isNull)
            {
                MessageBox.Show("ورودی یا ورودی های نامعتبر", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


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



        }

        async private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!WorkWithStrings.StringToIntValidations(txtProductCode.Text))
            {
                MessageBox.Show("مقادیر ورودی نامعتبر");
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
                        {
                            _unitOfWork.Save();
                            MessageBox.Show("رکورد با موفقیت حذف شد");
                            Reset();
                        }


                    }
                    else
                    {

                        MessageBox.Show("خطایی رخ داده است");

                    }






                }

            }

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



























        //---End Block of Class And Namespace------------------------

    }
}
