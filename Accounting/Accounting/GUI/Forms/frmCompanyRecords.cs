using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces;
using Accounting.Utilities;
using AccountingDLL;
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
    public partial class frmCompanyRecords : Form
    {
        public frmCompanyRecords()
        {
            InitializeComponent();
        }



        private void LoadData()
        {


            using (UnitOfWork _UnitOfWork = new UnitOfWork())
            {
                ICompanyRepository _CompanyRepository = _UnitOfWork.CompanyRepository;
                try
                {
                    DGV1.DataSource = _CompanyRepository.GetAll<Company>(n => n == n);
                    DGV1.Columns["id"].HeaderText = " کد شرکت";
                    DGV1.Columns["CompanyName"].HeaderText = " نام شرکت";
                }
                catch
                {
                    MessageBox.Show(" خطایی رخ داده است");
                }

            }



        }
        private void frmCompanyRecords_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            WorkWithExcel.ExportExcel(DGV1);
        }

        private void txtCompanyId_TextChanged(object sender, EventArgs e)
        {
            if (txtCompanyId.Text == "")
            {
                LoadData();
                return;
            }
            bool ValidationResult = WorkWithStrings.TextToIntVlaidation(txtCompanyId.Text);
            if (!ValidationResult)
            {
                // MessageBox.Show("فیلد کد باید عددی صحیح باشد ");
                txtCompanyId.Text = "";
                return;
            }




            using (UnitOfWork _UnitOfWork = new UnitOfWork())
            {
                ICompanyRepository _CompanyRepository = _UnitOfWork.CompanyRepository;
                try
                {


                    long CompanyId = long.Parse(txtCompanyId.Text);
                    DGV1.DataSource = _CompanyRepository.GetAll<Company>(n => n.id.ToString().Contains(CompanyId.ToString()));


                }
                catch
                {
                    MessageBox.Show(" خطایی رخ داده است");
                }


            }
        }
    }
}