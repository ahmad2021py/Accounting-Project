using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces.IRepositories;
using Accounting.Utilities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Accounting.GUI.Forms
{
    public partial class frmReturnFromBuyInvoice : Form
    {
        public frmReturnFromBuyInvoice()
        {
            InitializeComponent();
        }

        void reset()
        {
            txtBuyInvoiceCode.Text = "";
            txtReturnFromBuyInvoiceCode.Text = "";
            txtReturnFromBuy_Count.Text = "";
            lblStockCode.Text = "";


        }

        private void btnSelectBuyInvoiceCode_Click(object sender, EventArgs e)
        {
            frmBuyInvoiceRecords frmBuyInvoiceRecords = new frmBuyInvoiceRecords();
            if (frmBuyInvoiceRecords.ShowDialog() == DialogResult.OK)
            {
                frmBuyInvoiceRecords.Close();
                lblStockCode.Text = frmBuyInvoiceRecords._FKStock;
                txtBuyInvoiceCode.Text = frmBuyInvoiceRecords._BuyInvoiceCode;
                frmBuyInvoiceRecords = null;
            }
        }

        async private void btnCommit_Click(object sender, EventArgs e)
        {
            if (WorkWithStrings.StringIsNullOrEmptyOrWhiteSpace(txtBuyInvoiceCode.Text,
                txtReturnFromBuyInvoiceCode.Text,
                txtReturnFromBuy_Count.Text,
                lblStockCode.Text,
                bPersianCalenderTextBox1.Text))
            {
                MessageBox.Show("ورودی یا ورودی های نامعتبر", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!WorkWithStrings.StringToIntValidations(txtReturnFromBuy_Count.Text))
            {
                MessageBox.Show("ورودی غیر عدد صحیح میباشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            using (UnitOfWork unitOfWork = new UnitOfWork())
            {

                IReturnFromBuyIncoiceRepository returnFromBuyIncoiceRepository = unitOfWork.ReturnFromBuyIncoiceRepository;

                //-----txtReturnFromBuyInvoiceCode Validate-------
                bool intValidateResult = WorkWithStrings.StringToIntValidations();
                if (!intValidateResult)
                {
                    MessageBox.Show("ورودی نامعتبر");
                    return;
                }
                //-----
                //----- returnFromBuyInvoiceCode Validate to avoid duplication .------
                int returnFromBuyInvoiceCode = int.Parse(txtReturnFromBuyInvoiceCode.Text);
                bool returnFromBuyInvoiceCodeIsExists = await returnFromBuyIncoiceRepository.IsExist<ReturnFromBuyIncoice>(n => n.ReturnFromBuyInvoiceCode == returnFromBuyInvoiceCode);
                if (returnFromBuyInvoiceCodeIsExists)
                {
                    MessageBox.Show("فاکتور برگشت از فروشی با این کد وجود دارد");
                    return;
                }
                //-----

                //-----Add To ReturnFromBuyIncoice -----
                ReturnFromBuyIncoice returnFromBuyIncoiceRecord = new ReturnFromBuyIncoice()
                {
                    ReturnFromBuyInvoiceCode = returnFromBuyInvoiceCode,
                    FKBuyInvoice = txtBuyInvoiceCode.Text
                }
                ;

                bool AddResult = await returnFromBuyIncoiceRepository.Add<ReturnFromBuyIncoice>(returnFromBuyIncoiceRecord);
                if (!AddResult)
                {
                    MessageBox.Show("در افزودن رکورد خطایی رخ داده است");
                    return;
                }

                //-----Get Stock Record To Update Quantity-----
                IStockRepository stockRepository = unitOfWork.StockRepository;
                int stockCode = int.Parse(lblStockCode.Text);
                Stock dbRecord = await stockRepository.GetEntity<Stock>(n => n.StockCode == stockCode);

                //-----Update Quantity of Stock DbRecord ------
                dbRecord.Quantity -= int.Parse(txtReturnFromBuy_Count.Text);

                List<PropertyMap> stockPropertyToUpdate = new List<PropertyMap>()
                {

                    new PropertyMap()
                    {
                        PropertyName="Quantity" ,
                        PropertyValue=dbRecord.Quantity
                    }

                };

                bool updateResult = await stockRepository.UpdateMany<Stock>(n => n.StockCode == stockCode, stockPropertyToUpdate);
                if (!updateResult)
                {
                    MessageBox.Show("خطایی در اپدیت رکورد رخ داده است");
                    return;
                }

                unitOfWork.Save();
                MessageBox.Show("فاکتور با موفقیت ثبت شد");
                reset();
                //-----




            }






        }
    }
}
