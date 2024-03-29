﻿using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces.IRepositories;
using AccountingDLL;
using Stimulsoft.Report;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Accounting.GUI.Forms
{
    public partial class frmCustomerRecords : Form
    {
        //-----Fields-------------------
        #region class Fields
        private StiReport stiReport1;


        #endregion
        //------Methods------------
        public frmCustomerRecords()
        {
            InitializeComponent();
            stiReport1 = new StiReport();
            // How to Activate Stimulsoft
            Stimulsoft.Base.StiLicense.Key = "6vJhGtLLLz2GNviWmUTrhSqnOItdDwjBylQzQcAOiHn0s4gy0Fr5YoUZ9V00Y0igCSFQzwEqYBh/N77k4f0fWXTHW5rqeBNLkaurJDenJ9o97TyqHs9HfvINK18Uwzsc/bG01Rq+x3H3Rf+g7AY92gvWmp7VA2Uxa30Q97f61siWz2dE5kdBVcCnSFzC6awE74JzDcJMj8OuxplqB1CYcpoPcOjKy1PiATlC3UsBaLEXsok1xxtRMQ283r282tkh8XQitsxtTczAJBxijuJNfziYhci2jResWXK51ygOOEbVAxmpflujkJ8oEVHkOA/CjX6bGx05pNZ6oSIu9H8deF94MyqIwcdeirCe60GbIQByQtLimfxbIZnO35X3fs/94av0ODfELqrQEpLrpU6FNeHttvlMc5UVrT4K+8lPbqR8Hq0PFWmFrbVIYSi7tAVFMMe2D1C59NWyLu3AkrD3No7YhLVh7LV0Tttr/8FrcZ8xirBPcMZCIGrRIesrHxOsZH2V8t/t0GXCnLLAWX+TNvdNXkB8cF2y9ZXf1enI064yE5dwMs2fQ0yOUG/xornE";
            //Stimulsoft.Base.StiLicense.LoadFromFile("license.key");
            setDataGridViewSettings(DGV1);
        }
        public string _Row;
        public string _Address;
        public string _ZipCode;
        public string _City;
        public string _Email;
        public string _State;
        public string _Phone;
        public string _Name;
        public string _NationalCode;
        public string _creditor;
        public string _debtor;

      

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

        async void LoadData()
        {
            using (UnitOfWork _UnitOfWork = new UnitOfWork())
            {
                ICustomerRepository customerRepository = _UnitOfWork.CustomerRepository;
                //--------
                IEnumerable<Customer> IEnamrableCustomerDbRecords = await customerRepository.GetAll<Customer>(n => n == n);
                DGV1.DataSource = IEnamrableCustomerDbRecords;
                DGV1.Columns["Row"].HeaderText = "ردیف";
                DGV1.Columns["NationalCode"].HeaderText = " کد ملی";
                DGV1.Columns["Name"].HeaderText = " نام";
                DGV1.Columns["Phone"].HeaderText = " تلفن";
                DGV1.Columns["State"].HeaderText = " استان";
                DGV1.Columns["ZipCode"].HeaderText = " کد پستی";
                DGV1.Columns["Email"].HeaderText = " ایمیل";
                DGV1.Columns["City"].HeaderText = " شهر";
                DGV1.Columns["Address"].HeaderText = " آدرس";
                DGV1.Columns["debtor"].HeaderText = "بدهکار";
                DGV1.Columns["creditor"].HeaderText = " بستانکار";



                //----------------------------------



            }
        }



        private void frmCustomerRecords_Load(object sender, EventArgs e)
        {
            LoadData();

        }










        private void frmCustomerRecords_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        async private void txtNationalCode_TextChanged(object sender, EventArgs e)
        {
            if (txtNationalCode.Text == "")
            {
                LoadData();
                return;
            }


            using (UnitOfWork _UnitOfWork = new UnitOfWork())
            {
                ICustomerRepository _CustomerRepository = _UnitOfWork.CustomerRepository;


                IEnumerable<Customer> IEnamrableCustomerDbRecords = await _CustomerRepository.GetAll<Customer>(n => n.NationalCode.ToString().Contains(txtNationalCode.Text));
                DGV1.DataSource = IEnamrableCustomerDbRecords;



            }





        }

        async private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {
            if (txtCustomerName.Text == "")
            {
                LoadData();
                return;
            }



            using (UnitOfWork _UnitOfWork = new UnitOfWork())
            {
                ICustomerRepository _CustomerRepository = _UnitOfWork.CustomerRepository;


                IEnumerable<Customer> IEnamrableCustomerDbRecords = await _CustomerRepository.GetAll<Customer>(n => n.Name.Contains(txtCustomerName.Text));

                DGV1.DataSource = IEnamrableCustomerDbRecords;



            }

        }

        private void btnExport_Click(object sender, EventArgs e)
        {


            //Load File
            stiReport1.Load(Application.StartupPath + "/AppFiles/Customer.mrt");
            stiReport1.Compile();
            //Set Variables
            stiReport1["Row"] = _Row;
            stiReport1["Name"] = _Name;
            stiReport1["Email"] = _Email;
            stiReport1["Address"] = _Address;
            stiReport1["id"] = _NationalCode;
            stiReport1["NationalCode"] = _NationalCode;
            stiReport1["ZipCode"] = _ZipCode;
            stiReport1["State"] = _State;
            stiReport1["City"] = _City;
            stiReport1["Phone"] = _Phone;
            stiReport1["debtor"] = _debtor;
            stiReport1["creditor"] = _creditor;

            //--------Show------------
            stiReport1.Show();
            //---------
        }





        private void btnExcelExport_Click(object sender, EventArgs e)
        {
            WorkWithExcel.ExportExcel(DGV1);
        }

        private void DGV1_CellDoubleClick_(object sender, DataGridViewCellEventArgs e)
        {
            _Row = DGV1.Rows[e.RowIndex].Cells["Row"].Value.ToString();
            _NationalCode = DGV1.Rows[e.RowIndex].Cells["NationalCode"].Value.ToString();
            _Name = DGV1.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            _Phone = DGV1.Rows[e.RowIndex].Cells["Phone"].Value.ToString();
            _State = DGV1.Rows[e.RowIndex].Cells["State"].Value.ToString();
            _Email = DGV1.Rows[e.RowIndex].Cells["Email"].Value.ToString();
            _City = DGV1.Rows[e.RowIndex].Cells["City"].Value.ToString();
            _ZipCode = DGV1.Rows[e.RowIndex].Cells["ZipCode"].Value.ToString();
            _Address = DGV1.Rows[e.RowIndex].Cells["Address"].Value.ToString();
            _creditor = DGV1.Rows[e.RowIndex].Cells["creditor"].Value.ToString();
            _debtor = DGV1.Rows[e.RowIndex].Cells["debtor"].Value.ToString();



            this.DialogResult = DialogResult.OK;
        }

        private void DGV1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _Row = DGV1.Rows[e.RowIndex].Cells["Row"].Value.ToString();
            _NationalCode = DGV1.Rows[e.RowIndex].Cells["NationalCode"].Value.ToString();
            _Name = DGV1.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            _Phone = DGV1.Rows[e.RowIndex].Cells["Phone"].Value.ToString();
            _State = DGV1.Rows[e.RowIndex].Cells["State"].Value.ToString();
            _Email = DGV1.Rows[e.RowIndex].Cells["Email"].Value.ToString();
            _City = DGV1.Rows[e.RowIndex].Cells["City"].Value.ToString();
            _ZipCode = DGV1.Rows[e.RowIndex].Cells["ZipCode"].Value.ToString();
            _Address = DGV1.Rows[e.RowIndex].Cells["Address"].Value.ToString();
            _creditor = DGV1.Rows[e.RowIndex].Cells["creditor"].Value.ToString();
            _debtor = DGV1.Rows[e.RowIndex].Cells["debtor"].Value.ToString();
        }





































        //---End Block of Class And Namespace------------------------
    }
}
