using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using mgh;
using Accounting.Utilities;
using Accounting.DataLayer.Entities;

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
            string shamsiDate="";
            FarsiDate.MiladiToShamsi(DateTime.Now,ref shamsiDate);
            lblDate.Text = shamsiDate;

            //--------GetNowDay
            string ThisDay =ShamsiDay.GetThisTimeShamsiDay(DateTime.Now);
            lblThisDay.Text =ThisDay;

           
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
            frmLoginDetails frm = new frmLoginDetails();
            frm.ShowDialog();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            frmCustomer frm = new frmCustomer();
            frm.ShowDialog();
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
    }
}
