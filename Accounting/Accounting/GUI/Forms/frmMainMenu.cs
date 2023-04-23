﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
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
            ToolStripStatusLabel4.Text = System.DateTime.Now.ToString();
            // GetData();
        }
    

    

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login frm = new Login();
            frm.txtUserName.Text = "";
            frm.txtPassword.Text = "";
            frm.txtUserName.Focus();
            frm.Show();
        }

       

        private void btnRegistration_Click(object sender, EventArgs e)
        {

        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            frmLoginDetails frm = new frmLoginDetails();
            frm.ShowDialog();
        }

     
    }
}
