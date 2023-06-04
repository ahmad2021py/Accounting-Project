using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces.IRepositories;
using Accounting.Utilities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Accounting.GUI.Forms
{
    public partial class frmReturnFromSellIncoice : Form
    {
        static decimal TotaRetunFrmSellAmoun;
        public frmReturnFromSellIncoice()
        {
            InitializeComponent();
        }



        private void Reset()
        {
            txtReturnFromSell_Count.Text = "";
            txtReturnFromSell_UnitAmount.Text = "";
            txtProductSoldCode.Text = "";
            bPersianCalenderTextBox1.Text = "";
            lblCustomerCode.Text = "";
            lblStockCode.Text = "";
            lblTotaRetunFrmSellAmoun.Text = "";


        }


        private ReturnFromSellIncoice Fill__ReturnFromSellInvoiceRecord(ReturnFromSellIncoice returnFromSellInvoiceRecord)
        {
            returnFromSellInvoiceRecord.FKCustomer = long.Parse(lblCustomerCode.Text);
            returnFromSellInvoiceRecord.FKProductSold = int.Parse(txtProductSoldCode.Text);
            returnFromSellInvoiceRecord.FKStock = int.Parse(lblStockCode.Text);
            returnFromSellInvoiceRecord.ReturnFromSellIncoiceCode = txtReturnFromSellInvoiceCode.Text;
            WorkWithDate date = new WorkWithDate();
            returnFromSellInvoiceRecord.ReturnFromSellIncoiceDate = date.ShamsiToMiladi(bPersianCalenderTextBox1.Text);
            returnFromSellInvoiceRecord.ReturnQuantity = int.Parse(txtReturnFromSell_Count.Text);
            returnFromSellInvoiceRecord.TotalAmountFromReturnFromSellIncoice = decimal.Parse(lblTotaRetunFrmSellAmoun.Text);
            return returnFromSellInvoiceRecord;

        }


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            bool isNull = WorkWithStrings.StringIsNullOrEmptyOrWhiteSpace(bPersianCalenderTextBox1.Text,
                 lblStockCode.Text,
                 lblCustomerCode.Text,
                 txtProductSoldCode.Text,
                 txtReturnFromSell_UnitAmount.Text,
                 txtReturnFromSell_Count.Text);

            if (isNull)
            {
                MessageBox.Show("فیلد خالی یا نامعتبر");
                return;
            }

            if (!WorkWithStrings.StringToIntValidations(txtReturnFromSell_Count.Text, txtReturnFromSell_UnitAmount.Text))
            {
                MessageBox.Show("مقادیر ورودی غیر عدد صحیح");
                return;

            }
            int ReturnFromSell_count = int.Parse(txtReturnFromSell_Count.Text);
            int ReturnFromSell_UnitAmount = int.Parse(txtReturnFromSell_UnitAmount.Text);
            TotaRetunFrmSellAmoun = ReturnFromSell_count * ReturnFromSell_UnitAmount;
            lblTotaRetunFrmSellAmoun.Text = TotaRetunFrmSellAmoun.ToString();
        }

        async private void btnCommit_Click(object sender, EventArgs e)
        {
            bool isNullResult = WorkWithStrings.StringIsNullOrEmptyOrWhiteSpace(txtReturnFromSell_Count.Text, txtReturnFromSell_UnitAmount.Text, txtProductSoldCode.Text, lblCustomerCode.Text, lblStockCode.Text, lblTotaRetunFrmSellAmoun.Text, bPersianCalenderTextBox1.Text);
            if (isNullResult)
            {
                MessageBox.Show("مقادیر نامعتبر");
                return;
            }


            using (UnitOfWork unitOfWork = new UnitOfWork())
            {


                IProductSoldRepository productSoldRepository = unitOfWork.ProductSoldRepository;

                int productSoldCode = int.Parse(txtProductSoldCode.Text);
                bool productSoldIsExistResult = await productSoldRepository.IsExist<ProductSold>(n => n.ProductSoldTableCode == productSoldCode);

                if (!productSoldIsExistResult)
                {
                    MessageBox.Show("رکوردی با این کد در جدول محصولات فروش رفته وجو ندارد");

                    return;
                }

                ReturnFromSellIncoice returnFromSellInvoiceRecord = new ReturnFromSellIncoice();
                returnFromSellInvoiceRecord = Fill__ReturnFromSellInvoiceRecord(returnFromSellInvoiceRecord);



                //----------IsExist for avoid duplicate----------
                IReturnFromSellInvoiceRepository returnFromSellInvoiceRepository = unitOfWork.ReturnFromSellInvoicRepository;

                string returnFromSellIncoiceCode = txtReturnFromSellInvoiceCode.Text;

                bool isExistsResult = await returnFromSellInvoiceRepository.IsExist<ReturnFromSellIncoice>(n => n.ReturnFromSellIncoiceCode == returnFromSellIncoiceCode);

                if (isExistsResult)
                {
                    MessageBox.Show("کد فاکتور بازگشت از خرید تکراری است");
                    return;
                }
                //-----

                //----------add to ReturnFromSellIncoice---------
                bool addResult = await returnFromSellInvoiceRepository.Add<ReturnFromSellIncoice>(returnFromSellInvoiceRecord);

                if (!addResult)
                {
                    MessageBox.Show("در افزودن فاکتور به جدول بازگشت از فروش خطایی رخ داه است");
                    return;
                }

                //-----


                //------------------Update Quantity in Stock -----------
                IStockRepository stockRepository = unitOfWork.StockRepository;
                int returnQuantity = int.Parse(txtReturnFromSell_Count.Text);
                int stockCode = int.Parse(lblStockCode.Text);

                Stock stockDbRecord = await stockRepository.GetEntity<Stock>(n => n.StockCode == stockCode);
                stockDbRecord.Quantity += returnQuantity;
                List<PropertyMap> StockPopertiesToUpdate = new List<PropertyMap>()
                {

                    new PropertyMap()
                    {
                        PropertyName="Quantity" ,
                        PropertyValue = stockDbRecord.Quantity


                    }



                };


                bool addTostockResult = await stockRepository.UpdateMany<Stock>(n => n.StockCode == stockCode, StockPopertiesToUpdate);

                if (!addTostockResult)
                {
                    MessageBox.Show("در بروزرسانی تعداد انبار خطایی رخ داه است");
                    return;
                }
                //-----
                //------Save--------
                unitOfWork.Save();
                //-----
                MessageBox.Show("فاکتور با موفقیت ثبت شد");
                Reset();
                return;

            }

        }



        private void SelectCustomer_Click(object sender, EventArgs e)
        {
            frmCustomerRecords frmCustomerRecords = new frmCustomerRecords();
            if (frmCustomerRecords.ShowDialog() == DialogResult.OK)
            {

                frmCustomerRecords.Close();
                lblCustomerCode.Text = frmCustomerRecords._NationalCode;
                frmCustomerRecords = null;

            }

        }

        private void btnSelectProductInStock_Click(object sender, EventArgs e)
        {
            frmStockRecords frmStockRecords = new frmStockRecords();
            if (frmStockRecords.ShowDialog() == DialogResult.OK)
            {

                frmStockRecords.Close();
                lblStockCode.Text = frmStockRecords._StockCode;
                frmStockRecords = null;

            }
        }

        private void btnSelectSellInviceCode_Click(object sender, EventArgs e)
        {
            frmProductsSoldRecords frmProductsSoldRecords = new frmProductsSoldRecords();
            if (frmProductsSoldRecords.ShowDialog() == DialogResult.OK)
            {

                frmProductsSoldRecords.Close();
                txtProductSoldCode.Text = frmProductsSoldRecords._ProductSoldTableCode;
                frmProductsSoldRecords = null;

            }

        }






























        //----------------------------
    }
}
