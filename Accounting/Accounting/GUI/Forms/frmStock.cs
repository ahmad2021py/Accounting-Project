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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting.GUI.Forms
{
    public partial class frmStock : Form
    {
        public frmStock()
        {
            InitializeComponent();
        }


        private void Reset()
        {
            //--textboxes
            txtBuyPrice.Text = "";
            txtDescription.Text = "";
            txtProductId.Text = "";
            txtProductQuantity.Text = "";

            bPersianCalenderTextBox1.Text = "";
            txtProductId.Focus();
            ///----labels--------
            lblBuyPrice.Text = "";
            lblCategory.Text = "";
            lblCompany.Text = "";
            lblCount.Text = "";
            lblStockId.Text = "";
            lblFeatures.Text = "";
            lblGetDateTime.Text = "";
            lblPrice.Text = "";
            lblProductName.Text = "";

            bunifuCircleProgress1.Value = 0;
            bunifuCircleProgress4.Value = 0;

        }

        private bool IsNull()
        {
            if (txtBuyPrice.Text == "" ||
                txtDescription.Text == "" ||
               txtProductId.Text == "" ||
               txtProductQuantity.Text == "" ||

               bPersianCalenderTextBox1.Text == "")

                return true;
            else
            {
                return false;
            }

        }

        private Stock Fill__StockRecord(Stock stockRecord)
        {



            string ShamsiDate = bPersianCalenderTextBox1.Text;
            WorkWithDate workWithDate = new WorkWithDate();
            stockRecord.StockDate = workWithDate.ShamsiToMiladi(ShamsiDate);
            stockRecord.FKProductId = int.Parse(txtProductId.Text);
            stockRecord.Quantity = Convert.ToInt32(txtProductQuantity.Text);

            stockRecord.BuyPrice = Int32.Parse(txtBuyPrice.Text);
            stockRecord.Description = txtDescription.Text;

            return stockRecord;



        }


        private void FillControlersWithStockDbRecord(Stock dbStockRecord)
        {
            try
            {



                txtProductQuantity.Text = dbStockRecord.Quantity.ToString();
                WorkWithDate workWithDate = new WorkWithDate();
                string ShamsiDate = workWithDate.MiladiToShamsi(dbStockRecord.StockDate);
                bPersianCalenderTextBox1.Text = ShamsiDate;
                txtBuyPrice.Text = dbStockRecord.BuyPrice.ToString();

                txtDescription.Text = dbStockRecord.Description;
                txtProductId.Text = dbStockRecord.FKProductId.ToString();
                lblBuyPrice.Text = dbStockRecord.BuyPrice.ToString();
                lblCount.Text = dbStockRecord.Quantity.ToString();
                lblStockId.Text = dbStockRecord.Description.ToString();
                lblGetDateTime.Text = ShamsiDate;
                lblStockId.Text = dbStockRecord.id.ToString();



            }
            catch
            {
                MessageBox.Show("خطایی رخ داده است");
            }
        }




        private void btnShowFrmProduct_Click(object sender, EventArgs e)
        {
            frmProduct frm = new frmProduct();
            frm.txtProductCode.Text = txtProductId.Text;

            frm.ShowDialog();

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            frmProductRecords formProductRecords = new frmProductRecords(this);
            if (formProductRecords.ShowDialog() == DialogResult.OK)
            {

                formProductRecords.Close();
                this.lblCategory.Text = formProductRecords._Category;
                this.txtProductId.Text = formProductRecords._id;
                this.lblCompany.Text = formProductRecords._Company;
                this.lblFeatures.Text = formProductRecords._Features;
                this.lblPrice.Text = formProductRecords._Price;
                this.lblProductName.Text = formProductRecords._ProductName;
                formProductRecords = null;



            }



        }

        private void btnShowFrmStockRecords_Click(object sender, EventArgs e)
        {
            frmStockRecords frmStockRecords = new frmStockRecords();
            if (frmStockRecords.ShowDialog() == DialogResult.OK)
            {

                frmStockRecords.Close();
                this.txtProductId.Text = frmStockRecords._FKProductId;
                this.txtBuyPrice.Text = frmStockRecords._BuyPrice;
                this.txtDescription.Text = frmStockRecords._Description;
                this.txtProductQuantity.Text = frmStockRecords._Quantity;
                this.bPersianCalenderTextBox1.Text = frmStockRecords._StockDate;
                frmStockRecords = null;


            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            bool IntVlaidationResult = WorkWithStrings.TextToIntVlaidation(txtProductId.Text);
            bool IntVlaidationResult2 = WorkWithStrings.TextToIntVlaidation(txtProductQuantity.Text);
            bool DecimalVlaidationResult = WorkWithStrings.TextToDecimalVlaidation(txtBuyPrice.Text);

            if (!IntVlaidationResult || !IntVlaidationResult2 || !DecimalVlaidationResult)
            {
                // MessageBox.Show("فیلد کد باید عددی صحیح باشد ");
                txtProductId.Text = "";
                return;
            }


            try
            {

                using (UnitOfWork _UnitOfWork = new UnitOfWork())
                {
                    IStockRepository _StockRepository = _UnitOfWork.StockRepository;
                    if (!IsNull())
                    {

                        int productId = Int32.Parse(txtProductId.Text);
                        IProductRepository _ProductRepository = _UnitOfWork.ProductRepository;

                        bool StockResult = await _StockRepository.IsExist<Stock>(n => n.FKProductId == productId);
                        bool ProductResult = await _ProductRepository.IsExist<Product>(n => n.id == productId);
                        if (!ProductResult)
                        {
                            MessageBox.Show("محصولی با این کد وجود ندارد");
                            return;
                        }
                        if (!StockResult)
                        {

                            Stock StockRecord = new Stock();
                            StockRecord = Fill__StockRecord(StockRecord);
                            bool AddResult = await _StockRepository.Add<Stock>(StockRecord);

                            if (AddResult)
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

        private async void btnGetProductDetails_Click(object sender, EventArgs e)
        {
            try
            {

                using (UnitOfWork _unitOfWork = new UnitOfWork())
                {
                    IStockRepository _StockRepository = _unitOfWork.StockRepository;
                    int ProductId = Int32.Parse(txtProductId.Text);
                    bool result = await _StockRepository.IsExist<Stock>(n => n.FKProductId == ProductId);
                    if (result)
                    {
                        Stock record = await _StockRepository.GetEntity<Stock>(n => n.FKProductId == ProductId);
                        FillControlersWithStockDbRecord(record);

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

     async   private void btnUpdate_Click(object sender, EventArgs e)
        {
            bunifuCircleProgress1.Value += 10;
            try
            {
                bunifuCircleProgress1.Value += 10;
                if (!IsNull())
                {
                    bunifuCircleProgress1.Value += 10;
                    using (UnitOfWork _unitOfWork = new UnitOfWork())
                    {
                        bunifuCircleProgress1.Value += 10;
                        IStockRepository _StockRepository = _unitOfWork.StockRepository;
                        bunifuCircleProgress1.Value += 10;
                        Stock Instance = new Stock();
                        Instance = Fill__StockRecord(Instance);
                        int ProductCode = Convert.ToInt32(txtProductId.Text);
                        bunifuCircleProgress1.Value += 10;
                        bool UpdateProductResult = await _StockRepository.UpdateStock(Instance, n => n.FKProductId == Instance.FKProductId);
                        if (UpdateProductResult)
                        {
                            bunifuCircleProgress1.Value += 10;
                            MessageBox.Show("رکورد با موفقیت  بروز شد");
                            bunifuCircleProgress1.Value += 10;
                            _unitOfWork.Save();
                            bunifuCircleProgress1.Value += 10;
                            Reset();
                        }
                        else
                        {
                            bunifuCircleProgress1.ProgressColor = Color.Red;
                            MessageBox.Show("خطایی رخ داده است");
                            bunifuCircleProgress1.Value = 0;
                            return;
                        }

                    }
                }
                else
                {
                    bunifuCircleProgress1.ProgressColor = Color.Red;
                    MessageBox.Show("لطفا فیلد های خواسته شده را پر کنید");
                    bunifuCircleProgress1.Value = 0;
                    return;
                }
            }
            catch
            {
                bunifuCircleProgress1.ProgressColor = Color.Red;
                MessageBox.Show("خطایی رخ داده است");
                bunifuCircleProgress1.Value = 0;
                return;
            }
        }

        private void txtProductId_TextChanged(object sender, EventArgs e)
        {
            bool IntVlaidationResult = WorkWithStrings.TextToIntVlaidation(txtProductId.Text);


            if (!IntVlaidationResult)
            {
                // MessageBox.Show("فیلد کد باید عددی صحیح باشد ");
                txtProductId.Text = "";
                return;
            }

        }

        private void txtProductQuantity_TextChanged(object sender, EventArgs e)
        {

            bool IntVlaidationResult = WorkWithStrings.TextToIntVlaidation(txtProductQuantity.Text);


            if (!IntVlaidationResult)
            {
                // MessageBox.Show("فیلد کد باید عددی صحیح باشد ");
                txtProductId.Text = "";
                return;
            }

        }

        private void txtBuyPrice_TextChanged(object sender, EventArgs e)
        {

            bool DecimalVlaidationResult = WorkWithStrings.TextToDecimalVlaidation(txtBuyPrice.Text);

            if (!DecimalVlaidationResult)
            {
                // MessageBox.Show("فیلد کد باید عددی اعشاری باشد ");
                txtProductId.Text = "";
                return;
            }

        }

     

        private void frmStock_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Reset();
        }

      async  private void btnDelete_Click(object sender, EventArgs e)
        {
            bunifuCircleProgress4.Value += 10;
            try
            {
                bunifuCircleProgress4.Value += 10;
                if (MessageBox.Show("آیا از حذف رکورد اطمینان دارید ؟", "تایید کردن", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    bunifuCircleProgress4.Value += 10;
                    using (UnitOfWork _unitOfWork = new UnitOfWork())
                    {
                        bunifuCircleProgress4.Value += 10;

                        IStockRepository _StockRepository = _unitOfWork.StockRepository;

                        bunifuCircleProgress4.Value += 10;
                        int ProductCode = Convert.ToInt32(txtProductId.Text);
                        bunifuCircleProgress4.Value += 10;
                        bool result = await _StockRepository.IsExist<Stock>(N => N.FKProductId == ProductCode);
                        if (result)
                        {
                            bunifuCircleProgress4.Value += 10;
                            bool DeleteResult = await _StockRepository.DeleteByCondition<Stock>(n => n.FKProductId == ProductCode);
                            bunifuCircleProgress4.Value += 10;
                            if (DeleteResult)
                                MessageBox.Show("رکورد با موفقیت حذف شد");
                            bunifuCircleProgress4.Value += 10;
                            _unitOfWork.Save();
                            bunifuCircleProgress4.Value += 10;
                            Reset();


                        }
                        else
                        {
                            bunifuCircleProgress4.ProgressColor = Color.Red;
                            MessageBox.Show("خطایی رخ داده است");
                            bunifuCircleProgress4.Value = 0;
                            return;
                        }






                    }

                }
            }
            catch
            {
                bunifuCircleProgress4.ProgressColor = Color.Red;
                MessageBox.Show("خطایی رخ داده است");
                bunifuCircleProgress4.Value = 0;
                return;
            }
        }

        private void frmStock_Load(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
