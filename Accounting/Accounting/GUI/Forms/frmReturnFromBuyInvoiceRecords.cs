using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces.IRepositories;
using Accounting.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Accounting.GUI.Forms
{
    public partial class frmReturnFromBuyInvoiceRecords : Form
    {
        public frmReturnFromBuyInvoiceRecords()
        {
            InitializeComponent();
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
                DataTable dataTable = new DataTable();
                //--------------An Instanse to Store MildadiDates------------
                List<DateTime> MiladiDates = new List<DateTime>();
                //-----
                //-------Get MiladiDateTime List and Convert To ShamsiDate--------- 
                foreach (var n in DbReturnFromBuyIncoicelist)
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
                //-------------seed data to dataTable---------
                for (int i = 0; i < DbReturnFromBuyIncoicelist.Count; i++)
                {
                    DataRow dataRow = dataTable.NewRow();
                    dataRow["Row"] = DbReturnFromBuyIncoicelist[i].Row;
                    dataRow["ReturnFromBuyInvoiceCode"] = DbReturnFromBuyIncoicelist[i].ReturnFromBuyInvoiceCode;
                    dataRow["FKBuyInvoice"] = DbReturnFromBuyIncoicelist[i].FKBuyInvoice;
                    dataRow["ReturnFromBuyInvoiceDate"] = ShamsiDates[i];
                    dataRow["ReturnQuantity"] = DbReturnFromBuyIncoicelist[i].ReturnQuantity;
                    dataTable.Rows.Add(dataRow);

                }
                //-----
                //-------------Show In DGV1-----------
                DGV1.DataSource = dataTable;
                //-----
                //-------------Replace Default Header Text with DataTable Columns Captions----------
                foreach (DataGridViewColumn n in DGV1.Columns)
                {
                    n.HeaderText = dataTable.Columns[n.Name].Caption;
                }
                //-----




            }

        }

        private void frmReturnFromBuyInvoiceRecords_Load(object sender, System.EventArgs e)
        {
            LoadData();
        }
    }
}
