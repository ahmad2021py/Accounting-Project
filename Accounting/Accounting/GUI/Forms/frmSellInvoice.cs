using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces.IRepositories;
using Accounting.Utilities;
using System;
using System.Windows.Forms;

namespace Accounting.GUI.Forms
{
    public partial class frmSellInvoice : Form
    {
        public frmSellInvoice()
        {
            InitializeComponent();
        }




        private void Reset()
        {
            txtSellInvoiceCode.Text = "";
            txtOff.Text = "";
            txtSellCount.Text = "";
            txtSellPricePerUnit.Text = "";
            lblCustomerCode.Text = "";
            lblCustomerDebt.Text = "";
            lblCustomerDebtWithThisSellInvoice.Text = "";
            lblInvoiceTotalPrice.Text = "";
            lblStockCode.Text = "";
            lblTotalSellPrice.Text = "";
            lblTotaSellAmountWithOff.Text = "";

        }







        private void SelectCustomer_Click(object sender, EventArgs e)
        {
            frmCustomerRecords frmCustomerRecords = new frmCustomerRecords();
            if (frmCustomerRecords.ShowDialog() == DialogResult.OK)
            {

                frmCustomerRecords.Close();
                lblCustomerCode.Text = frmCustomerRecords._NationalCode;
                lblCustomerDebt.Text = frmCustomerRecords._debtor;
                frmCustomerRecords = null;

            }

        }




        private SellInvoice Fill__SellInvoiceRecord(SellInvoice Invoice)
        {
            Invoice.FKCustomer = long.Parse(lblCustomerCode.Text);
            Invoice.Quantity = int.Parse(txtSellCount.Text);
            Invoice.TotalSellAmount = Decimal.Parse(lblTotaSellAmountWithOff.Text);
            Invoice.FKStock = int.Parse(lblStockCode.Text);
            Invoice.SellInvoiceCode = txtSellInvoiceCode.Text;
            WorkWithDate date = new WorkWithDate();
            Invoice.SellInvoiceDate = date.ShamsiToMiladi(bPersianCalenderTextBox1.Text);
            Invoice.Off = int.Parse(txtOff.Text);
            Invoice.SellPricePerUnit = decimal.Parse(txtSellPricePerUnit.Text);

            return Invoice;

        }










        bool txtSellCountValidate()
        {
            int Count = int.Parse(txtSellCount.Text);
            int RequestCount = int.Parse(lblStockTotalQuantity.Text);
            if (Count > RequestCount || Count <=0)
            {
                return false;
            }
            return true;
        }





        private void btnSelectProductInStock_Click(object sender, EventArgs e)
        {
            frmStockRecords frmStockRecords = new frmStockRecords();
            if (frmStockRecords.ShowDialog() == DialogResult.OK)
            {

                frmStockRecords.Close();
                lblStockCode.Text = frmStockRecords._StockCode;
                lblStockTotalQuantity.Text = frmStockRecords._Quantity;
                frmStockRecords = null;

            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            bool isNullResult = WorkWithStrings.StringIsNullOrEmptyOrWhiteSpace(bPersianCalenderTextBox1.Text,
                lblCustomerCode.Text,
                lblStockCode.Text,
                txtSellPricePerUnit.Text,
                txtSellCount.Text,
                txtOff.Text,
                txtSellInvoiceCode.Text


                );


            if (isNullResult)
            {
                MessageBox.Show("فیلد خالی یا نامعتبر");
                return;
            }

            if (!WorkWithStrings.StringToIntValidations(txtSellCount.Text, txtOff.Text) || !WorkWithStrings.StringToDecimalValidations(txtSellPricePerUnit.Text, this.lblCustomerDebt.Text))
            {
                MessageBox.Show("مقادیر ورودی نامعتر");
                return;

            }
            if (!txtSellCountValidate())
            {

                errorProvider1.SetError(txtSellCount, "تعداد درخواستی از تعداد کل موجودی انبار بیشتر است .");
                return;

            }
            int SellCount = int.Parse(txtSellCount.Text);
            decimal SellPricePerUnit = decimal.Parse(txtSellPricePerUnit.Text);
            decimal TotalSellCost = (SellCount * SellPricePerUnit);
            lblTotalSellPrice.Text = TotalSellCost.ToString();

            int Off = int.Parse(txtOff.Text);
            decimal CalculateOff = (((Off * TotalSellCost) / 100));
            decimal TotalPriceWithOff = TotalSellCost - CalculateOff;
            lblTotaSellAmountWithOff.Text = TotalPriceWithOff.ToString();
            decimal CustomerDebt = decimal.Parse(this.lblCustomerDebt.Text);
            lblCustomerDebtWithThisSellInvoice.Text = (CustomerDebt + TotalPriceWithOff).ToString();
        }

        async private void btnCommit_Click(object sender, EventArgs e)
        {
            bool isNullResult = WorkWithStrings.StringIsNullOrEmptyOrWhiteSpace(bPersianCalenderTextBox1.Text,
                lblCustomerCode.Text,
                lblStockCode.Text,
                txtSellPricePerUnit.Text,
                txtSellCount.Text,
                txtOff.Text,
                txtSellInvoiceCode.Text


                );


            if (isNullResult)
            {
                MessageBox.Show("فیلد خالی یا نامعتبر");
                return;
            }


            using (UnitOfWork _UnitOfWork = new UnitOfWork())
            {


                ISelllnvoiceRepository _SellInvoiceRepository = _UnitOfWork.SellInvoiceRepository;

                string SellInvoiceCode = txtSellInvoiceCode.Text;
                bool SellInvoiceResult = await _SellInvoiceRepository.IsExist<SellInvoice>(n => n.SellInvoiceCode == SellInvoiceCode);

                if (SellInvoiceResult)
                {
                    MessageBox.Show("یک فاکتور با این کد در جدول فروش وجود دارد");

                    return;
                }

                SellInvoice SellInvoiceRecord = new SellInvoice();
                SellInvoiceRecord = Fill__SellInvoiceRecord(SellInvoiceRecord);

                bool AddResult = await _SellInvoiceRepository.Add<SellInvoice>(SellInvoiceRecord);

                if (!AddResult)
                {
                    MessageBox.Show("در افزودن فاکتور خطایی رخ داه است");
                    return;
                }
             


                StockbyOnlyQuantityField stockbyOnlyQuantityField = new StockbyOnlyQuantityField();
                int StockTotalQuantity = int.Parse(lblStockTotalQuantity.Text);
                int SellCount = int.Parse(txtSellCount.Text);
                stockbyOnlyQuantityField.Quantity = StockTotalQuantity - SellCount;
                int StockCode = int.Parse(lblStockCode.Text);
                IStockRepository _StockRepository = _UnitOfWork.StockRepository;
                bool UpdateResult = await _StockRepository.UpdateStockProductQuantity(stockbyOnlyQuantityField, n => n.StockCode == StockCode);
                if (UpdateResult)
                {
                    _UnitOfWork.Save();
                    MessageBox.Show("فاکتور با موفقیت ثبت شد");
                    Reset();
                    return;

                }
                else
                {
                    MessageBox.Show("خطایی رخ داده است");
                    return;
                }



            }


        }


















        //-------------------------

    }
}
