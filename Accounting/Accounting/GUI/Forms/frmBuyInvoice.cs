using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces.IRepositories;
using Accounting.Utilities;
using System;
using System.Windows.Forms;

namespace Accounting.GUI.Forms
{
    public partial class frmBuyInvoice : Form
    {
        public frmBuyInvoice()
        {
            InitializeComponent();
        }

        private void SelectCustomer_Click(object sender, System.EventArgs e)
        {
            frmProductRecords frmProductRecords = new frmProductRecords(this);
            if (frmProductRecords.ShowDialog() == DialogResult.OK)
            {

                frmProductRecords.Close();
                lblProductCode.Text = frmProductRecords._ProductCode;
                frmProductRecords = null;

            }

        }



        private void Reset()
        {
            txtBuyCount.Text = "";
            txtOff.Text = "";
            txtBuyInvoiceCode.Text = "";
            txtBuyPricePerUnit.Text = "";
            txtOff.Text = "";
            txtStockCodeForStore.Text = "";
            lblInvoiceTotalPrice.Text = "";
            lblSellerCreditor.Text = "";
            lblSellerCreditorWithThisInvoice.Text = "";
            lblSellerCode.Text = "";
            lblTotalBuyAmountWithOff.Text = "";
            lblTotalBuyPrice.Text = "";

        }

        private BuyInvoice Fill__BuyInvoiceRecord(BuyInvoice BuyInvoiceInastance)
        {
            BuyInvoiceInastance.FKSeller = long.Parse(lblSellerCode.Text);
            BuyInvoiceInastance.BuyCount = int.Parse(txtBuyCount.Text);
            BuyInvoiceInastance.TotalBuyAmount = Decimal.Parse(lblTotalBuyAmountWithOff.Text);
            BuyInvoiceInastance.BuyInvoiceCode = txtBuyInvoiceCode.Text;
            BuyInvoiceInastance.FKStock = int.Parse(txtStockCodeForStore.Text);
            BuyInvoiceInastance.FKSeller = long.Parse(lblSellerCode.Text);
            WorkWithDate date = new WorkWithDate();
            BuyInvoiceInastance.BuyInvoiceDate = date.ShamsiToMiladi(bPersianCalenderTextBox1.Text);
            BuyInvoiceInastance.Off = int.Parse(txtOff.Text);
            BuyInvoiceInastance.BuyPricePerUnit = decimal.Parse(txtBuyPricePerUnit.Text);

            return BuyInvoiceInastance;

        }

































        private void Calculate_Click(object sender, EventArgs e)
        {
            bool isNull = WorkWithStrings.StringIsNullOrEmptyOrWhiteSpace(lblSellerCode.Text, bPersianCalenderTextBox1.Text, txtBuyPricePerUnit.Text, txtBuyCount.Text, txtOff.Text, txtBuyInvoiceCode.Text, lblSellerCode.Text);
            if (isNull)
            {
                MessageBox.Show("فیلد خالی یا دارای فاصله");
                return;
            }
            bool decimalvalidate = WorkWithStrings.StringToDecimalValidations(txtBuyPricePerUnit.Text);
            bool intValidate = WorkWithStrings.StringToIntValidations(txtBuyCount.Text, txtOff.Text);

            if (!decimalvalidate || !intValidate)
            {
                MessageBox.Show("مقادیر ورودی نامعتبر");
                return;

            }

            int BuyCount = int.Parse(txtBuyCount.Text);
            decimal BuyPricePerUnit = decimal.Parse(txtBuyPricePerUnit.Text);
            decimal TotalBuyCost = (BuyCount * BuyPricePerUnit);
            lblTotalBuyPrice.Text = TotalBuyCost.ToString();

            int Off = int.Parse(txtOff.Text);
            decimal CalculateOff = (((Off * TotalBuyCost) / 100));
            decimal TotalPriceWithOff = TotalBuyCost - CalculateOff;
            lblTotalBuyAmountWithOff.Text = TotalPriceWithOff.ToString();

            decimal SellerCreditor = decimal.Parse(this.lblSellerCreditor.Text);
            lblSellerCreditorWithThisInvoice.Text = (SellerCreditor + TotalPriceWithOff).ToString();
        }

        async private void btnCommit_Click(object sender, EventArgs e)
        {
            bool decimalvalidate = WorkWithStrings.StringToDecimalValidations(txtBuyPricePerUnit.Text);
            bool intValidate = WorkWithStrings.StringToIntValidations(txtBuyCount.Text, txtOff.Text);


            if (!decimalvalidate || !intValidate)
            {
                MessageBox.Show("مقادیر ورودی نامعتبر");
                return;

            }

            using (UnitOfWork _UnitOfWork = new UnitOfWork())
            {


                IBuyInvoiceRepository _BuyInvoiceRepository = _UnitOfWork.BuyInvoiceRepository;

                string BuyInvoiceCode = txtBuyInvoiceCode.Text;
                bool BuyInvoiceResult = await _BuyInvoiceRepository.IsExist<BuyInvoice>(n => n.BuyInvoiceCode == BuyInvoiceCode);

                if (BuyInvoiceResult)
                {
                    MessageBox.Show("یک فاکتور با این کد در جدول خرید وجود دارد");

                    return;
                }

                BuyInvoice BuyInvoiceRecord = new BuyInvoice();
                BuyInvoiceRecord = Fill__BuyInvoiceRecord(BuyInvoiceRecord);

                bool AddResult = await _BuyInvoiceRepository.Add<BuyInvoice>(BuyInvoiceRecord);

                if (!AddResult)
                {
                    MessageBox.Show("در افزودن فاکتور خطایی رخ داه است");
                    return;
                }






                int StockCode = int.Parse(txtStockCodeForStore.Text);
                IStockRepository _StockRepository = _UnitOfWork.StockRepository;

                bool StockCodeIsExists = await _StockRepository.IsExist<Stock>(n => n.StockCode == StockCode);
                if (StockCodeIsExists)
                {
                    MessageBox.Show("رکوردی با این کد انبار وجود دارد");

                    return;
                }

                WorkWithDate workWithDate = new WorkWithDate();
                Stock stockRecord = new Stock()
                {



                    BuyPrice = decimal.Parse(lblTotalBuyAmountWithOff.Text),
                    Description = txtDescription.Text,
                    FKProduct = int.Parse(lblProductCode.Text),
                    Quantity = int.Parse(txtBuyCount.Text),
                    StockCode = int.Parse(txtStockCodeForStore.Text),
                    StockDate = workWithDate.ShamsiToMiladi(bPersianCalenderTextBox1.Text),



                };
                bool StockCodeAdd = await _StockRepository.Add<Stock>(stockRecord);
                if (!StockCodeAdd)
                {
                    MessageBox.Show("در افزودن به انبار خطایی رخ داده است");
                    return;
                }


                else
                {

                    _UnitOfWork.Save();
                    MessageBox.Show("فاکتور با موفقیت ثبت شد");
                    Reset();
                    return;

                }



            }
        }

        private void SelectSeller_Click(object sender, EventArgs e)
        {
            frmSellerRecords frmSellerRecords = new frmSellerRecords();
            if (frmSellerRecords.ShowDialog() == DialogResult.OK)
            {

                frmSellerRecords.Close();
                this.lblSellerCode.Text = frmSellerRecords._NationalCode;
                this.lblSellerCreditor.Text = frmSellerRecords._creditor;

                frmSellerRecords = null;


            }
        }

        private void btnSelectProductCode_Click(object sender, EventArgs e)
        {
            frmProductRecords frmProductRecords = new frmProductRecords(this);
            if (frmProductRecords.ShowDialog() == DialogResult.OK)
            {

                frmProductRecords.Close();
                this.lblProductCode.Text = frmProductRecords._ProductCode;

                frmProductRecords = null;


            }
        }
    }
}
