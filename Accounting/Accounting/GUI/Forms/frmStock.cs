using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces.IRepositories;
using Accounting.Utilities;
using System;
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

            txtDescription.Text = "";
            txtProductCode.Text = "";
            txtProductQuantity.Text = "";

            bPersianCalenderTextBox1.Text = "";
            txtProductCode.Focus();




        }



        private Stock Fill__StockRecord(Stock stockRecord)
        {



            string ShamsiDate = bPersianCalenderTextBox1.Text;
            WorkWithDate workWithDate = new WorkWithDate();
            stockRecord.StockCode = Convert.ToInt32(txtStockCode.Text);

            stockRecord.StockDate = workWithDate.ShamsiToMiladi(ShamsiDate);
            stockRecord.FKProduct = int.Parse(txtProductCode.Text);
            stockRecord.Quantity = Convert.ToInt32(txtProductQuantity.Text);


            stockRecord.Description = txtDescription.Text;

            return stockRecord;



        }

        private StockEntityWithoutRowPropertyForUpdate Fill__StockRecord(StockEntityWithoutRowPropertyForUpdate stockRecord)
        {



            string ShamsiDate = bPersianCalenderTextBox1.Text;
            WorkWithDate workWithDate = new WorkWithDate();
            stockRecord.StockCode = Convert.ToInt32(txtStockCode.Text);
            stockRecord.BuyPrice = Convert.ToInt32(txtBuyPrice.Text);

            stockRecord.StockDate = workWithDate.ShamsiToMiladi(ShamsiDate);
            stockRecord.FKProduct = int.Parse(txtProductCode.Text);
            stockRecord.Quantity = Convert.ToInt32(txtProductQuantity.Text);


            stockRecord.Description = txtDescription.Text;

            return stockRecord;



        }





        private void btnShowFrmProduct_Click(object sender, EventArgs e)
        {
            frmProduct frm = new frmProduct();
            frm.txtProductCode.Text = txtProductCode.Text;

            frm.ShowDialog();

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            frmProductRecords formProductRecords = new frmProductRecords(this);
            if (formProductRecords.ShowDialog() == DialogResult.OK)
            {

                formProductRecords.Close();
                this.txtProductCode.Text = formProductRecords._ProductCode;

                formProductRecords = null;



            }



        }

        private void btnShowFrmStockRecords_Click(object sender, EventArgs e)
        {
            frmStockRecords frmStockRecords = new frmStockRecords();
            if (frmStockRecords.ShowDialog() == DialogResult.OK)
            {

                frmStockRecords.Close();
                this.txtStockCode.Text = frmStockRecords._StockCode;
                this.txtProductCode.Text = frmStockRecords._FKProductId;
                this.txtDescription.Text = frmStockRecords._Description;
                this.txtProductQuantity.Text = frmStockRecords._Quantity;
                this.txtBuyPrice.Text = frmStockRecords._BuyPrice;
                this.bPersianCalenderTextBox1.Text = frmStockRecords._StockDate;
                frmStockRecords = null;


            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {




            bool IntVlaidationResult = WorkWithStrings.StringToIntValidations(txtProductCode.Text, txtProductQuantity.Text);


            if (!IntVlaidationResult)
            {
                // MessageBox.Show("فیلد کد باید عددی صحیح باشد ");
                txtProductCode.Text = "";
                return;
            }



            using (UnitOfWork _UnitOfWork = new UnitOfWork())
            {

                bool isNullResult = WorkWithStrings.StringIsNullOrEmptyOrWhiteSpace(bPersianCalenderTextBox1.Text,
                    txtStockCode.Text,
                    txtProductQuantity.Text,
                    txtProductCode.Text,
                    txtDescription.Text);

                if (isNullResult)
                {


                    MessageBox.Show("لطفا فیلد های خواسته شده را پر کنید");
                    return;


                }

                IStockRepository _StockRepository = _UnitOfWork.StockRepository;

                int StockCode = Int32.Parse(txtStockCode.Text);
                int ProductCode = Int32.Parse(txtProductCode.Text);
                IProductRepository _ProductRepository = _UnitOfWork.ProductRepository;

                bool StockResult = await _StockRepository.IsExist<Stock>(n => n.StockCode == StockCode);
                bool ProductResult = await _ProductRepository.IsExist<Product>(n => n.ProductCode == ProductCode);

                if (!ProductResult)
                {
                    MessageBox.Show("محصولی با این کد وجود ندارد");
                    return;
                }
                if (StockResult)
                {

                    MessageBox.Show("این کد انبار از قبل وجود دارد ");
                    Reset();
                    return;
                }

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
                    MessageBox.Show("خطایی در افزودن رکورد رخ داده است");
                }


            }

        }



        async private void btnUpdate_Click(object sender, EventArgs e)
        {



            bool isNullResult = WorkWithStrings.StringIsNullOrEmptyOrWhiteSpace(bPersianCalenderTextBox1.Text,
                txtStockCode.Text,
                txtProductQuantity.Text,
                txtProductCode.Text,
                txtDescription.Text);

            if (isNullResult)
            {


                MessageBox.Show("لطفا فیلد های خواسته شده را پر کنید");
                return;


            }

            if (!WorkWithStrings.StringToDecimalValidations(txtBuyPrice.Text) || !WorkWithStrings.StringToIntValidations(txtProductCode.Text, txtProductQuantity.Text, this.txtStockCode.Text))
            {
                MessageBox.Show("مقادیر ورودی نامعتبر");
                return;

            }



            using (UnitOfWork _unitOfWork = new UnitOfWork())
            {

                IStockRepository _StockRepository = _unitOfWork.StockRepository;

                StockEntityWithoutRowPropertyForUpdate Instance = new StockEntityWithoutRowPropertyForUpdate();
                Instance = Fill__StockRecord(Instance);
                int stockCode = int.Parse(txtStockCode.Text);
                bool UpdateProductResult = await _StockRepository.UpdateStock(Instance, n => n.StockCode == stockCode);
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

        private void txtProductId_TextChanged(object sender, EventArgs e)
        {
            bool IntVlaidationResult = WorkWithStrings.StringToIntValidations(txtProductCode.Text);


            if (!IntVlaidationResult)
            {
                // MessageBox.Show("فیلد کد باید عددی صحیح باشد ");
                txtProductCode.Text = "";
                return;
            }

        }

        private void txtProductQuantity_TextChanged(object sender, EventArgs e)
        {

            bool IntVlaidationResult = WorkWithStrings.StringToIntValidations(txtProductQuantity.Text);


            if (!IntVlaidationResult)
            {
                // MessageBox.Show("فیلد کد باید عددی صحیح باشد ");
                txtProductCode.Text = "";
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

        async private void btnDelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("آیا از حذف رکورد اطمینان دارید ؟", "تایید کردن", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {

                using (UnitOfWork _unitOfWork = new UnitOfWork())
                {


                    IStockRepository _StockRepository = _unitOfWork.StockRepository;


                    int StockCode = Convert.ToInt32(txtStockCode.Text);

                    bool result = await _StockRepository.IsExist<Stock>(N => N.StockCode == StockCode);
                    if (result)
                    {

                        bool DeleteResult = await _StockRepository.DeleteByCondition<Stock>(n => n.StockCode == StockCode);

                        if (DeleteResult)
                            MessageBox.Show("رکورد با موفقیت حذف شد");

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

        }

        private void frmStock_Load(object sender, EventArgs e)
        {
            Reset();
        }

        private void txtProductQuantity_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
