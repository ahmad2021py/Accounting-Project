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
            string shamsiDate="";
            shamsiDate= workWithDate1.MiladiToShamsi(DateTime.Now);
           
          
            lblDate.Text = shamsiDate;

            //--------GetNowDay
            WorkWithDate workWithDate = new WorkWithDate();
            string ThisShamsiDay = workWithDate.GetShamsiDayNameByMiladiDate(DateTime.Now);
            lblThisDay.Text = ThisShamsiDay;
          

           
        }
    

    

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();
            frmLogin frm = new frmLogin();
            frm.txtUserName.Text = "";
            frm.txtPassword.Text = "";
            frm.txtUserName.Focus();
            frm.Show();
        }

       

     

        private void btnUsers_Click(object sender, EventArgs e)
        {
            frmUserReords frm = new frmUserReords();
            frm.ShowDialog();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            frmUserRegistration frm = new frmUserRegistration();
            frm.ShowDialog();
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
            frm.ShowDialog();

        }

        private void btnProdut_Click(object sender, EventArgs e)
        {
            frmProduct frm = new frmProduct();
            frm.ShowDialog();
            this.Hide();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            frmCustomer frm = new frmCustomer();
            frm.ShowDialog();
            this.Hide();

        }

        private void btnCompany_Click(object sender, EventArgs e)
        {
            frmCompany frm = new frmCompany();
            frm.ShowDialog();
        }

        private void btnfrmLoginDetails_Click(object sender, EventArgs e)
        {
            frmLoginDetails frm=new frmLoginDetails();
            frm.ShowDialog();
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            frmStock frm = new frmStock();
            frm.ShowDialog();
            this.Hide();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            frmCategory frm = new frmCategory();
            frm.ShowDialog();
            this.Hide();
        }

        private void btnSaleAndBuy_Click(object sender, EventArgs e)
        {
            frmSaleAndBuy frm = new frmSaleAndBuy();
            frm.ShowDialog();
            this.Hide();
        }
    }
}
