using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces.IRepositories;
using Accounting.Utilities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Accounting.GUI.Forms
{
    public partial class frmOperationBenefitCalculate : Form
    {
        public frmOperationBenefitCalculate()
        {
            InitializeComponent();
        }

        async private void btnCalculate_Click(object sender, EventArgs e)
        {
            bool isNull = WorkWithStrings.StringIsNullOrEmptyOrWhiteSpace(txtPersianCalenderFrom.Text, txtPersianCalenderTo.Text, txtCostOfOperations.Text);
            if (isNull)
            {
                MessageBox.Show("ورودی یا ورودی های نامعتبر", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }




            using (UnitOfWork _unitOfWork = new UnitOfWork())
            {


                ISelllnvoiceRepository selllnvoiceRepository = _unitOfWork.SellInvoiceRepository;
                WorkWithDate workwithdate = new WorkWithDate();
                //-----Get Target Duruing Date----
                DateTime MiladiDate = workwithdate.ShamsiToMiladi(txtPersianCalenderFrom.Text);
                DateTime finallMiladiDate = workwithdate.ShamsiToMiladi(txtPersianCalenderTo.Text);
                //-----
                //------Get SellInvoite in Duruing Date and get its TotalSellAmount , SellProductStockCodes per one -----
                var Sellresult = await selllnvoiceRepository.GetAll<SellInvoice>(n => n.SellInvoiceDate >= MiladiDate && n.SellInvoiceDate <= finallMiladiDate);
                decimal TotalSellAmount = 0;
                List<int> SellStockCodes = new List<int>();
                int AllSellQuantity = 0;
                foreach (var n in Sellresult)
                {
                    TotalSellAmount += n.TotalSellAmount;
                    SellStockCodes.Add(n.FKStock);
                    AllSellQuantity += n.Quantity;


                }
                //-----
                //--Get BuyInvoice with SellStockCodes   --------
                IBuyInvoiceRepository buylnvoiceRepository = _unitOfWork.BuyInvoiceRepository;
                List<BuyInvoice> buyresult = new List<BuyInvoice>();

                for (int i = 0; i < SellStockCodes.Count; i++)
                {
                    int stockCode = SellStockCodes[i];
                    buyresult.Add(await buylnvoiceRepository.GetEntity<BuyInvoice>(n => n.FKStock == stockCode));


                }
                decimal allBuyTotalAmount = 0;
                foreach (var n in buyresult)
                {
                    allBuyTotalAmount += n.TotalBuyAmount;
                }
                //----
                //---calculate Operation benefit--------
                decimal Rowbonifiet = TotalSellAmount - allBuyTotalAmount;
                decimal OperationCost = decimal.Parse(txtCostOfOperations.Text);
                decimal Operationbenefit = Rowbonifiet - OperationCost;
                lblBenefit.Text = Operationbenefit.ToString();
                lblAllSellQuantity.Text = AllSellQuantity.ToString();
                //-----

            }


        }











        //------------------------------
    }
}
