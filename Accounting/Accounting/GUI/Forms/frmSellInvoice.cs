using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces;
using Accounting.DataLayer.Interfaces.IRepositories;
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
    public partial class frmSellInvoice : Form
    {
        public frmSellInvoice()
        {
            InitializeComponent();
        }


        private bool IsNull()
        {
            if (
               string.IsNullOrEmpty(txtInvoiceCode.Text) ||
                  string.IsNullOrEmpty(txtOff.Text) ||
                  string.IsNullOrEmpty(txtSellCount.Text) ||
                  string.IsNullOrEmpty(txtSellPricePerUnit.Text) ||
                  string.IsNullOrEmpty(lblStockCode.Text) ||
                  string.IsNullOrEmpty(lblCustomerCode.Text) ||
                  string.IsNullOrEmpty(bPersianCalenderTextBox1.Text) ||


                  string.IsNullOrWhiteSpace(txtInvoiceCode.Text) ||
                  string.IsNullOrWhiteSpace(txtOff.Text) ||
                  string.IsNullOrWhiteSpace(txtSellCount.Text) ||
                  string.IsNullOrWhiteSpace(txtSellPricePerUnit.Text) ||
                  string.IsNullOrWhiteSpace(lblStockCode.Text) ||
                  string.IsNullOrWhiteSpace(bPersianCalenderTextBox1.Text) ||
                  string.IsNullOrWhiteSpace(lblCustomerCode.Text)

                  )
            {

                return true;
            }
            return false;



        }



        private void Reset()
        {
            txtInvoiceCode.Text = "";
            txtOff.Text = "";
            txtSellCount.Text = "";
            txtSellPricePerUnit.Text = "";
            lblCustomerCode.Text = "";
            lblCustomerDebt.Text = "";
            lblCustomerDebtWithThisInvoice.Text = "";
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




        private Invoice Fill__InvoiceRecord(Invoice Invoice)
        {
            Invoice.FKCustomer = long.Parse(lblCustomerCode.Text);
            Invoice.Quantity = int.Parse(txtSellCount.Text);
            Invoice.TotalAmount = Decimal.Parse(lblTotaSellAmountWithOff.Text);
            Invoice.FKStock = int.Parse(lblStockCode.Text);
            Invoice.InvoiceCode = txtInvoiceCode.Text;
            WorkWithDate date = new WorkWithDate();
            Invoice.InvoiceDate = date.ShamsiToMiladi(bPersianCalenderTextBox1.Text);
            Invoice.Off = int.Parse(txtOff.Text);
            Invoice.SellPricePerUnit = decimal.Parse(txtSellPricePerUnit.Text);

            return Invoice;

        }










        bool txtSellCountValidate()
        {
            int Count = int.Parse(txtSellCount.Text);
            int RequestCount = int.Parse(lblStockTotalQuantity.Text);
            if (Count > RequestCount)
            {

                return false;
            }
            return true;
        }


        private bool Validations()

        {



            if (!WorkWithStrings.TextToIntVlaidation(txtSellCount.Text))
            {
                // MessageBox.Show("تعداد نامعتبر");
                return false;
            }
            else if (!WorkWithStrings.TextToDecimalVlaidation(txtSellPricePerUnit.Text))
            {

                // MessageBox.Show("قیمت نامعتبر");
                return false;


            }

            else if (!WorkWithStrings.TextToIntVlaidation(txtOff.Text))
            {
                // MessageBox.Show("میزان تخفیف نامعتبر");
                return false;
            }


            else if (!WorkWithStrings.TextToDecimalVlaidation(this.lblCustomerDebt.Text))
            {
                //  MessageBox.Show("بدهکاری نامعتبر");
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsNull())
            {
                MessageBox.Show("فیلد خالی یا نامعتبر");
                return;
            }

            if (!Validations())
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
            lblCustomerDebtWithThisInvoice.Text = (CustomerDebt + TotalPriceWithOff).ToString();
        }

        async private void btnCommit_Click(object sender, EventArgs e)
        {
            IsNull();


            using (UnitOfWork _UnitOfWork = new UnitOfWork())
            {


                IInvoiceRepository _InvoiceRepository = _UnitOfWork.InvoiceRepository;

                string InvoiceCode = txtInvoiceCode.Text;
                bool InvoiceResult = await _InvoiceRepository.IsExist<Invoice>(n => n.InvoiceCode == InvoiceCode);

                if (InvoiceResult)
                {
                    MessageBox.Show("یک فاکتور با این کد در جدول فروش وجود دارد");

                    return;
                }

                Invoice InvoiceRecord = new Invoice();
                InvoiceRecord = Fill__InvoiceRecord(InvoiceRecord);

                bool AddResult = await _InvoiceRepository.Add<Invoice>(InvoiceRecord);

                if (!AddResult)
                {
                    MessageBox.Show("در افزودن فاکتور خطایی رخ داه است");
                    return;
                }
                ProductSold productSoldRecord = new ProductSold() { FKInvoice = InvoiceRecord.InvoiceCode };
                IProductSoldRepository _ProductSoldRepository = _UnitOfWork.ProductSoldRepository;
                bool AddToProductSoldResult = await _ProductSoldRepository.Add<ProductSold>(productSoldRecord);
                if (!AddToProductSoldResult)
                {
                    MessageBox.Show("در افزودن به جدول فروش خطایی رخ داه است");
                    return;
                }


                StockbyOnlyQuantityField stockbyOnlyQuantityField = new StockbyOnlyQuantityField();
                int StockTotalQuantity = int.Parse(lblStockTotalQuantity.Text);
                int SellCount = int.Parse(txtSellCount.Text);
                stockbyOnlyQuantityField.Quantity = StockTotalQuantity - SellCount;
                int StockCode = int.Parse(lblStockCode.Text);
                IStockRepository _StockRepository = _UnitOfWork.StockRepository;
                bool UpdateResult = await _StockRepository.UpdateStock(stockbyOnlyQuantityField, n => n.StockCode == StockCode);
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


    }
}
