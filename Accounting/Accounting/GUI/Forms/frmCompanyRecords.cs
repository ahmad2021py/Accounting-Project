using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces.IRepositories;
using Accounting.Utilities;
using AccountingDLL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Accounting.GUI.Forms
{
    public partial class frmCompanyRecords : Form
    {
        public frmCompanyRecords()
        {
            InitializeComponent(); 
            setDataGridViewSettings(DGV1);
        }


        public string _CompanyName;
      

        void setDataGridViewSettings(DataGridView dataGridView)
        {
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.ColumnHeadersHeight = 50;
            DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
            Font font = new Font("Microsoft Sans Serif", 12);

            dataGridViewCellStyle.Font = font;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
            dataGridView.ColumnHeadersHeight = 50;
            dataGridView.Dock = DockStyle.Right;
            dataGridView.RowHeadersWidth = 30;
            dataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView.RowsDefaultCellStyle.Font = font;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Size size = new Size();
            size.Width = 800;
            size.Height = 600;

            dataGridView.Size = size;

        }
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