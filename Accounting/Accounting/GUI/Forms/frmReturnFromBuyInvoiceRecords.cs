﻿using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces.IRepositories;
using Accounting.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Accounting.GUI.Forms
{
    public partial class frmReturnFromBuyInvoiceRecords : Form
    {
        public frmReturnFromBuyInvoiceRecords()
        {
            InitializeComponent();  
            setDataGridViewSettings(DGV1);
        }


     

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
        private DataTable DesignAndFillDataTable(List<ReturnFromBuyIncoice> returnFromBuyInvoiceRecords)
        {
            DataTable dataTable = new DataTable();
            //-----------Design datatable---------
            //----------- Create a DataTable and add 6 Columns to it---------
            //  DataTable dataTable = new DataTable();
            dataTable.Clear();
            dataTable.Columns.Add("Row", typeof(int));
            dataTable.Columns.Add("ReturnFromBuyInvoiceCode", typeof(int));
            dataTable.Columns.Add("FKBuyInvoice", typeof(string));
            dataTable.Columns.Add("ReturnFromBuyInvoiceDate", typeof(string));
            dataTable.Columns.Add("ReturnQuantity", typeof(int));


            dataTable.Columns["Row"].Caption = "ردیف ";
            dataTable.Columns["ReturnFromBuyInvoiceCode"].Caption = " کد فاکتور بازگشت از خرید";
            dataTable.Columns["FKBuyInvoice"].Caption = "کد فاکتور خرید";
            dataTable.Columns["ReturnFromBuyInvoiceDate"].Caption = "تاریخ فاکتور بازگشت از خرید";
            dataTable.Columns["ReturnQuantity"].Caption = "تعداد بازگشتی از خرید";



            //-----

            //--------------An Instanse to Store MildadiDates------------
            List<DateTime> MiladiDates = new List<DateTime>();
            //-----
            //-------Get MiladiDateTime List and Convert To ShamsiDate--------- 
            foreach (var n in returnFromBuyInvoiceRecords)
            {
                MiladiDates.Add(n.ReturnFromBuyInvoiceDate);
            }
            WorkWithDate workWithDate = new WorkWithDate();
            List<string> ShamsiDates = new List<string>();
            foreach (var n in MiladiDates)
            {
                ShamsiDates.Add(workWithDate.MiladiToShamsi(n));
            }
            //-----
            //-------------seed data to dataTable---------
            for (int i = 0; i < returnFromBuyInvoiceRecords.Count; i++)
            {
                DataRow dataRow = dataTable.NewRow();
                dataRow["Row"] = returnFromBuyInvoiceRecords[i].Row;
                dataRow["ReturnFromBuyInvoiceCode"] = returnFromBuyInvoiceRecords[i].ReturnFromBuyInvoiceCode;
                dataRow["FKBuyInvoice"] = returnFromBuyInvoiceRecords[i].FKBuyInvoice;
                dataRow["ReturnFromBuyInvoiceDate"] = ShamsiDates[i];
                dataRow["ReturnQuantity"] = returnFromBuyInvoiceRecords[i].ReturnQuantity;
                dataTable.Rows.Add(dataRow);

            }
            //-----
            return dataTable;
        }
        async void LoadData()
        {


            using (UnitOfWork _UnitOfWork = new UnitOfWork())
            {
                IReturnFromBuyIncoiceRepository returnFromBuyInvoiceRepository = _UnitOfWork.ReturnFromBuyIncoiceRepository;

                //--------

                IEnumerable<ReturnFromBuyIncoice> DbEnabrableRecords = await returnFromBuyInvoiceRepository.GetAll<ReturnFromBuyIncoice>(n => n == n);
                List<ReturnFromBuyIncoice> DbReturnFromBuyIncoicelist = new List<ReturnFromBuyIncoice>(DbEnabrableRecords);
                //-----




                //--------Fill DataTable-----------
                DataTable customeDataTable = DesignAndFillDataTable(DbReturnFromBuyIncoicelist);
                //-----
                //-------------Show In DGV1-----------

                DGV1.DataSource = customeDataTable;
                //-----
                //-------------Replace Default Header Text with DataTable Columns Captions----------
                foreach (DataGridViewColumn n in DGV1.Columns)
                {
                    n.HeaderText = customeDataTable.Columns[n.Name].Caption;
                }
                //-----




            }

        }

        private void frmReturnFromBuyInvoiceRecords_Load(object sender, System.EventArgs e)
        {
            LoadData();
        }

        async private void btnSearchByDate_Click(object sender, EventArgs e)
        {
            if (bPersianCalenderTextBox1.Text == "")
            {
                LoadData();
            }
            else
            {
                using (UnitOfWork _UnitOfWork = new UnitOfWork())
                {
                    IReturnFromBuyIncoiceRepository returnFromBuyInvoiceRepository = _UnitOfWork.ReturnFromBuyIncoiceRepository;

                    string ShamsiDate = bPersianCalenderTextBox1.Text;
                    WorkWithDate workWithDate = new WorkWithDate();
                    DateTime MiladiDate = workWithDate.ShamsiToMiladi(ShamsiDate);


                    IEnumerable<ReturnFromBuyIncoice> enumerableCollection = await returnFromBuyInvoiceRepository.GetAll<ReturnFromBuyIncoice>(n => n.ReturnFromBuyInvoiceDate == MiladiDate);
                    List<ReturnFromBuyIncoice> ReturnFromSellInvoiceRecords = new List<ReturnFromBuyIncoice>(enumerableCollection);
                    DataTable customdataTable = DesignAndFillDataTable(ReturnFromSellInvoiceRecords);
                    DGV1.DataSource = customdataTable;



                }


























                //--------------------------------------------
            }
        }

        async private void txtReturnFromBuyInvoiceCode_TextChanged(object sender, EventArgs e)
        {
            if (txtReturnFromBuyInvoiceCode.Text == "")
            {
                LoadData();
                return;
            }





            using (UnitOfWork _UnitOfWork = new UnitOfWork())
            {
                IReturnFromBuyIncoiceRepository returnFromBuyIncoiceRepository = _UnitOfWork.ReturnFromBuyIncoiceRepository;
                try
                {


                    long returnFromBuyIncoiceCode = long.Parse(txtReturnFromBuyInvoiceCode.Text);
                    var returnFromBuyIncoiceDbRecords = await returnFromBuyIncoiceRepository.GetAll<ReturnFromBuyIncoice>(n => n.ReturnFromBuyInvoiceCode.ToString().Contains(txtReturnFromBuyInvoiceCode.Text.ToString()));
                    DGV1.DataSource = returnFromBuyIncoiceDbRecords;


                }
                catch
                {
                    MessageBox.Show(" خطایی رخ داده است");
                }


            }
        }
















        //-----------------------
    }
}
