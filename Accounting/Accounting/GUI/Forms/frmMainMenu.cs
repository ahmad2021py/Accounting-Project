using System;
using System.Windows.Forms;
using Accounting.Utilities;

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

            this.Hide();
            WorkWithGlobalForms.frmLogin = new frmLogin();
            WorkWithGlobalForms.frmLogin.txtUserName.Text = "";
            WorkWithGlobalForms.frmLogin.txtPassword.Text = "";
            WorkWithGlobalForms.frmLogin.txtUserName.Focus();
            WorkWithGlobalForms.frmLogin.Show();
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

        private void btnSaleAndBuy_Click(object sender, EventArgs e)
        {
            frmSaleAndBuy frmSaleAndBuy = new frmSaleAndBuy();
            if (frmSaleAndBuy.ShowDialog() == DialogResult.OK)
            {

                frmSaleAndBuy.Close();
                frmSaleAndBuy = null;

            }

        }

        private void frmMainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();
            this.Hide();
        }
    }
}
