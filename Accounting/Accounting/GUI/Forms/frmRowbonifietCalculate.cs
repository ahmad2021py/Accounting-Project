using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces.IRepositories;
using Accounting.DataLayer.Services.Repositories;
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
    public partial class frmRowbonifietCalculate : Form
    {
        public frmRowbonifietCalculate()
        {
            InitializeComponent();
        }

        async private void button1_Click(object sender, EventArgs e)
        {
            bool isNull = WorkWithStrings.StringIsNullOrEmptyOrWhiteSpace(txtPersianCalenderFrom.Text, txtPersianCalenderTo.Text);
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
                int AllSellQuantity=0;
                foreach (var n in Sellresult)
                {
                    TotalSellAmount += n.TotalSellAmount;
                    SellStockCodes.Add(n.FKStock);
                    AllSellQuantity+=n.Quantity;


                }
                //-----
                //--Get BuyInvoice with SellStockCodes   --------
                IBuyInvoiceRepository buylnvoiceRepository = _unitOfWork.BuyInvoiceRepository;
                List<BuyInvoice> buyresult=new List<BuyInvoice>();

                for (int i=0;i< SellStockCodes.Count;i++)
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
                //---calculate Row benefit--------
                decimal Rowbonifiet = TotalSellAmount - allBuyTotalAmount;
                lblBenefit.Text = Rowbonifiet.ToString();
                lblAllSellQuantity.Text = AllSellQuantity.ToString();
                //-----


            }

        }

        private void frmRowbonifietCalculate_Load(object sender, EventArgs e)
        {

        }







        //----------------
    }
}
