﻿using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces.IRepositories;
using Accounting.Utilities;
using AccountingDLL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Accounting.GUI.Forms
{
    public partial class frmCompanyRecords : Form
    {
        public frmCompanyRecords()
        {
            InitializeComponent();
        }


        public string _CompanyName;
        private async void LoadData()
        {


            using (UnitOfWork _UnitOfWork = new UnitOfWork())
            {
                ICompanyRepository _CompanyRepository = _UnitOfWork.CompanyRepository;
                //try
                //{
                IEnumerable<Company> IenumerableComapnyDbRecords = await _CompanyRepository.GetAll<Company>(n => n == n);

                DGV1.DataSource = IenumerableComapnyDbRecords;
                DGV1.Columns["Row"].HeaderText = " ردیف ";
                DGV1.Columns["CompanyCode"].HeaderText = " کد شرکت";
                DGV1.Columns["CompanyName"].HeaderText = " نام شرکت";
                //}
                //catch
                //{
                //    MessageBox.Show(" خطایی رخ داده است");
                //}

            }



        }
        private void frmCompanyRecords_Load(object sender, EventArgs e)
        {
            LoadData();
        }


        async private void txtCompanyId_TextChanged(object sender, EventArgs e)
        {
            if (txtCompanyId.Text == "")
            {
                LoadData();
                return;
            }
            bool ValidationResult = WorkWithStrings.StringToIntValidations(txtCompanyId.Text);
            if (!ValidationResult)
            {
                // MessageBox.Show("فیلد کد باید عددی صحیح باشد ");
                txtCompanyId.Text = "";
                return;
            }




            using (UnitOfWork _UnitOfWork = new UnitOfWork())
            {
                ICompanyRepository _CompanyRepository = _UnitOfWork.CompanyRepository;
                //try
                //{


                long CompanyId = long.Parse(txtCompanyId.Text);
                IEnumerable<Company> IenumerableompanyDbRecords = await _CompanyRepository.GetAll<Company>(n => n.Row.ToString().Contains(CompanyId.ToString()));
                DGV1.DataSource = IenumerableompanyDbRecords;


                //}
                //catch
                //{
                //    MessageBox.Show(" خطایی رخ داده است");
                //}


            }
        }


        async private void txtCompanyName_TextChanged(object sender, EventArgs e)
        {
            if (txtCompanyName.Text == "")
            {
                LoadData();
                return;
            }


            using (UnitOfWork _UnitOfWork = new UnitOfWork())
            {
                ICompanyRepository _CompanyRepository = _UnitOfWork.CompanyRepository;
                //try
                //{

                IEnumerable<Company> IenumerableompanyDbRecords = await _CompanyRepository.GetAll<Company>(n => n.CompanyName.ToString().Contains(txtCompanyName.Text));
                DGV1.DataSource = IenumerableompanyDbRecords;


                //}
                //catch
                //{
                //    MessageBox.Show(" خطایی رخ داده است");
                //}


            }
        }

        private void frmCompanyRecords_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void DGV1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            _CompanyName = DGV1.Rows[e.RowIndex].Cells["CompanyName"].Value.ToString();

            this.DialogResult = DialogResult.OK;


        }

        private void DGV1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            _CompanyName = DGV1.Rows[e.RowIndex].Cells["CompanyName"].Value.ToString();
            this.DialogResult = DialogResult.OK;
        }

        private void btnExcelExport_Click(object sender, EventArgs e)
        {
            WorkWithExcel.ExportExcel(DGV1);
        }
    }
}