using Accounting.Utilities;
using System;
using System.Windows.Forms;

namespace Accounting.GUI.Forms
{
    public partial class frmMainMenu : Form
    {

        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {

            //------GetNowDate
            WorkWithDate workWithDate1 = new WorkWithDate();
            string shamsiDate = "";
            shamsiDate = workWithDate1.MiladiToShamsi(DateTime.Now);


            lblDate.Text = shamsiDate;

            //--------GetNowDay
            WorkWithDate workWithDate = new WorkWithDate();
            string ThisShamsiDay = workWithDate.GetShamsiDayNameByMiladiDate(DateTime.Now);
            lblThisDay.Text = ThisShamsiDay;



        }




        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {


            frmLogin frm = new frmLogin();
            frm.Show();
            this.Close();
        }







        private void btnRegistration_Click(object sender, EventArgs e)
        {
            frmUserRegistration frmUserRegistration = new frmUserRegistration();
            if (frmUserRegistration.ShowDialog() == DialogResult.OK)
            {

                frmUserRegistration.Close();
                frmUserRegistration = null;

            }
        }

        private void StatusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            lblTime.Text = DateTime.Now.Hour.ToString("0#");
            lblTime.Text += " : ";
            lblTime.Text += DateTime.Now.Minute.ToString("0#");
            lblTime.Text += " : ";
            lblTime.Text += DateTime.Now.Second.ToString("0#");

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            frmCompany frm = new frmCompany();
            frm.Show();
            this.Close();

        }

        private void btnProdut_Click(object sender, EventArgs e)
        {

            frmProduct formProduct = new frmProduct();
            if (formProduct.ShowDialog() == DialogResult.OK)
            {

                formProduct.Close();

            }

        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            frmCustomer frmCustomer = new frmCustomer();
            if (frmCustomer.ShowDialog() == DialogResult.OK)
            {

                frmCustomer.Close();
                frmCustomer = null;

            }

        }

        private void btnCompany_Click(object sender, EventArgs e)
        {
            frmCompany frmCompany = new frmCompany();
            if (frmCompany.ShowDialog() == DialogResult.OK)
            {

                frmCompany.Close();
                frmCompany = null;

            }
        }

        private void btnfrmLoginDetails_Click(object sender, EventArgs e)
        {
            frmLoginDetails frmLoginDetails = new frmLoginDetails();
            if (frmLoginDetails.ShowDialog() == DialogResult.OK)
            {

                frmLoginDetails.Close();
                frmLoginDetails = null;

            }
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            frmStock frmStock = new frmStock();
            if (frmStock.ShowDialog() == DialogResult.OK)
            {

                frmStock.Close();
                frmStock = null;

            }
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            frmCategory frmCategory = new frmCategory();
            if (frmCategory.ShowDialog() == DialogResult.OK)
            {

                frmCategory.Close();
                frmCategory = null;

            }
        }


        private void frmMainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();
            this.Hide();
        }



        private void ویرایشوثبتمحصولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduct formProduct = new frmProduct();
            if (formProduct.ShowDialog() == DialogResult.OK)
            {

                formProduct.Close();

            }
        }

        private void لیستمحصولاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductRecords frmProductRecords = new frmProductRecords(this);
            if (frmProductRecords.ShowDialog() == DialogResult.OK)
            {

                frmProductRecords.Close();
                frmProductRecords = null;

            }
        }

        private void ویرایشوثبتمشتریToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomer frmCustomer = new frmCustomer();
            if (frmCustomer.ShowDialog() == DialogResult.OK)
            {

                frmCustomer.Close();
                frmCustomer = null;

            }

        }

        private void لیستمشتریانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomerRecords frmCustomerRecords = new frmCustomerRecords();
            if (frmCustomerRecords.ShowDialog() == DialogResult.OK)
            {

                frmCustomerRecords.Close();
                frmCustomerRecords = null;

            }
        }

        private void ویرایشوثبتکالاهادرانبارToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStock frmStock = new frmStock();
            if (frmStock.ShowDialog() == DialogResult.OK)
            {

                frmStock.Close();
                frmStock = null;

            }
        }

        private void لیستکالاهایانبارToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStockRecords frmStockRecords = new frmStockRecords();
            if (frmStockRecords.ShowDialog() == DialogResult.OK)
            {

                frmStockRecords.Close();
                frmStockRecords = null;

            }
        }



        private void لیستشرکتهاToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void دستهبندیمحصولاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCompany frmCompany = new frmCompany();
            if (frmCompany.ShowDialog() == DialogResult.OK)
            {

                frmCompany.Close();
                frmCompany = null;

            }
        }

        private void دستهبندیمحصولاتToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCategory frmCategory = new frmCategory();
            if (frmCategory.ShowDialog() == DialogResult.OK)
            {

                frmCategory.Close();
                frmCategory = null;

            }
        }

        private void لیستشرکتهاToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmCompanyRecords frmCompanyRecords = new frmCompanyRecords();
            if (frmCompanyRecords.ShowDialog() == DialogResult.OK)
            {

                frmCompanyRecords.Close();
                frmCompanyRecords = null;

            }
        }

        private void جزToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoginDetails frmLoginDetails = new frmLoginDetails();
            if (frmLoginDetails.ShowDialog() == DialogResult.OK)
            {

                frmLoginDetails.Close();
                frmLoginDetails = null;

            }
        }

        private void جزئیاتورودToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoginDetails frmLoginDetails = new frmLoginDetails();
            if (frmLoginDetails.ShowDialog() == DialogResult.OK)
            {

                frmLoginDetails.Close();
                frmLoginDetails = null;

            }
        }

        private void فروشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSellInvoice frmSellInvoice = new frmSellInvoice();
            if (frmSellInvoice.ShowDialog() == DialogResult.OK)
            {

                frmSellInvoice.Close();
                frmSellInvoice = null;

            }
        }

        private void hihdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductsSoldRecords frmProductsSoldRecords = new frmProductsSoldRecords();
            if (frmProductsSoldRecords.ShowDialog() == DialogResult.OK)
            {

                frmProductsSoldRecords.Close();
                frmProductsSoldRecords = null;

            }
        }

        private void ثبتخریدوفروشکالاToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void فروشکالاToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ویرایشوثبتفروشندهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSeller frmSeller = new frmSeller();
            if (frmSeller.ShowDialog() == DialogResult.OK)
            {

                frmSeller.Close();
                frmSeller = null;

            }
        }

        private void لیستفروشندگانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSellerRecords frmSellerRecords = new frmSellerRecords();
            if (frmSellerRecords.ShowDialog() == DialogResult.OK)
            {

                frmSellerRecords.Close();
                frmSellerRecords = null;

            }
        }

        private void مدیریتکاربرانToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmUserRegistration frmUserRegistration = new frmUserRegistration();
            if (frmUserRegistration.ShowDialog() == DialogResult.OK)
            {

                frmUserRegistration.Close();
                frmUserRegistration = null;

            }
        }

        private void لیستکاربرانToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmUserReords frmUserReords = new frmUserReords();
            if (frmUserReords.ShowDialog() == DialogResult.OK)
            {

                frmUserReords.Close();
                frmUserReords = null;

            }
        }

        private void خریدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuyInvoice frmBuyInvoice = new frmBuyInvoice();
            if (frmBuyInvoice.ShowDialog() == DialogResult.OK)
            {

                frmBuyInvoice.Close();
                frmBuyInvoice = null;

            }
        }

        private void بازگشتازخریدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReturnFromSellIncoice frmReturnFromSell = new frmReturnFromSellIncoice();
            if (frmReturnFromSell.ShowDialog() == DialogResult.OK)
            {

                frmReturnFromSell.Close();
                frmReturnFromSell = null;

            }
        }

        private void بازگشتازخریدToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmReturnFromBuyInvoice frmReturnFromBuyInvoice = new frmReturnFromBuyInvoice();
            if (frmReturnFromBuyInvoice.ShowDialog() == DialogResult.OK)
            {

                frmReturnFromBuyInvoice.Close();
                frmReturnFromBuyInvoice = null;

            }
        }

        private void لیستفاکتورهایبازگشتازفروشToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReturnFromSellIncoiceRecords frmReturnFromSellIncoiceRecords = new frmReturnFromSellIncoiceRecords();
            if (frmReturnFromSellIncoiceRecords.ShowDialog() == DialogResult.OK)
            {

                frmReturnFromSellIncoiceRecords.Close();
                frmReturnFromSellIncoiceRecords = null;

            }
        }

        private void لیستفاکتورهایبازگشتازفروشToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmReturnFromSellIncoiceRecords frmReturnFromSellIncoiceRecords = new frmReturnFromSellIncoiceRecords();
            if (frmReturnFromSellIncoiceRecords.ShowDialog() == DialogResult.OK)
            {

                frmReturnFromSellIncoiceRecords.Close();
                frmReturnFromSellIncoiceRecords = null;

            }
        }

        private void لیستفاکتورهایفروشToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void لیستفاکتورهایفروشToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmSellInvoiceRecords frmSellInvoiceRecords = new frmSellInvoiceRecords();
            if (frmSellInvoiceRecords.ShowDialog() == DialogResult.OK)
            {

                frmSellInvoiceRecords.Close();
                frmSellInvoiceRecords = null;

            }
        }

        private void لیستفاکتورهایخریدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuyInvoiceRecords frmBuyInvoiceRecords = new frmBuyInvoiceRecords();
            if (frmBuyInvoiceRecords.ShowDialog() == DialogResult.OK)
            {

                frmBuyInvoiceRecords.Close();
                frmBuyInvoiceRecords = null;

            }
        }

        private void لیستفاکتورهایبازگشتازخریدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReturnFromBuyInvoiceRecords frmReturnFromBuyInvoiceRecords = new frmReturnFromBuyInvoiceRecords();
            if (frmReturnFromBuyInvoiceRecords.ShowDialog() == DialogResult.OK)
            {

                frmReturnFromBuyInvoiceRecords.Close();
                frmReturnFromBuyInvoiceRecords = null;
            }

        }

        private void ثبتچکToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChequeRegistration frmChequeRegistration = new frmChequeRegistration();
            if (frmChequeRegistration.ShowDialog() == DialogResult.OK)
            {

                frmChequeRegistration.Close();
                frmChequeRegistration = null;

            }
        }

        private void اطلاعاتچکهاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChequeRecords frmChequeRecords = new frmChequeRecords();
            if (frmChequeRecords.ShowDialog() == DialogResult.OK)
            {

                frmChequeRecords.Close();
                frmChequeRecords = null;

            }
        }
































        //-------------------------------
    }
}
