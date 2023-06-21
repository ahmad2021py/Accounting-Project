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
    public partial class frmSellInvoiceRecords : Form
    {
        public string _SellInvoiceCode;

        public frmSellInvoiceRecords()
        {
            InitializeComponent();

        }


        DataTable DesignAndFillDataTable(List<SellInvoice> DbSellInvoicelist)
        {

            DataTable dataTable = new DataTable();
            //-----------Design datatable---------
            //----------- Create a DataTable and add 6 Columns to it---------
            //  DataTable dataTable = new DataTable();
            dataTable.Clear();
            dataTable.Columns.Add("Row", typeof(int));
            dataTable.Columns.Add("SellInvoiceCode", typeof(string));
            dataTable.Columns.Add("SellInvoiceDate", typeof(string));
            dataTable.Columns.Add("FKCustomer", typeof(long));
            dataTable.Columns.Add("FKStock", typeof(int));
            dataTable.Columns.Add("Quantity", typeof(int));
            dataTable.Columns.Add("TotalSellAmount", typeof(decimal));
            dataTable.Columns.Add("SellPricePerUnit", typeof(decimal));
            dataTable.Columns.Add("Off", typeof(int));


            dataTable.Columns["Row"].Caption = " ردیف ";
            dataTable.Columns["SellInvoiceCode"].Caption = " کد فاکتور";
            dataTable.Columns["SellInvoiceDate"].Caption = " تاریخ فاکتور";
            dataTable.Columns["FKCustomer"].Caption = " کد مشتری";
            dataTable.Columns["FKStock"].Caption = "کد انبار";
            dataTable.Columns["Quantity"].Caption = "تعداد";
            dataTable.Columns["TotalSellAmount"].Caption = " کل مبلغ فروش";
            dataTable.Columns["SellPricePerUnit"].Caption = "قیمت هر واحد فروش";
            dataTable.Columns["Off"].Caption = " تخفیف";
            //-----

            //--------------An Instanse to Store MildadiDates------------
            List<DateTime> MiladiDates = new List<DateTime>();
            //-----
            //-------Get MiladiDateTime List and Convert To ShamsiDate--------- 
            foreach (var n in DbSellInvoicelist)
            {
                MiladiDates.Add(n.SellInvoiceDate);
            }
            WorkWithDate workWithDate = new WorkWithDate();
            List<string> ShamsiDates = new List<string>();
            foreach (var n in MiladiDates)
            {
                ShamsiDates.Add(workWithDate.MiladiToShamsi(n));
            }
            //-----
            //-------------seed data to dataTable---------
            for (int i = 0; i < DbSellInvoicelist.Count; i++)
            {
                DataRow dataRow = dataTable.NewRow();
                dataRow["Row"] = DbSellInvoicelist[i].Row;
                dataRow["SellInvoiceCode"] = DbSellInvoicelist[i].SellInvoiceCode;
                dataRow["SellInvoiceDate"] = ShamsiDates[i];
                dataRow["FKCustomer"] = DbSellInvoicelist[i].FKCustomer;
                dataRow["FKStock"] = DbSellInvoicelist[i].FKStock;
                dataRow["Quantity"] = DbSellInvoicelist[i].Quantity;
                dataRow["TotalSellAmount"] = DbSellInvoicelist[i].TotalSellAmount;
                dataRow["SellPricePerUnit"] = DbSellInvoicelist[i].SellPricePerUnit;
                dataRow["Off"] = DbSellInvoicelist[i].Off;
                dataTable.Rows.Add(dataRow);

            }
            //-----
            return dataTable;

        }
        async void LoadData()
        {
            using (UnitOfWork _UnitOfWork = new UnitOfWork())
            {
                ISelllnvoiceRepository selllnvoiceRepository = _UnitOfWork.SellInvoiceRepository;


                //---------Get List Of SellInvoice Table Records-----------
                IEnumerable<SellInvoice> EnumerableSellInvoicelist = await selllnvoiceRepository.GetAll<SellInvoice>(n => n == n);
                List<SellInvoice> DbSellInvoicelist = new List<SellInvoice>(EnumerableSellInvoicelist);
                //-----

                //-------------Show In DGV1-----------
                DataTable customeDataTable = DesignAndFillDataTable(DbSellInvoicelist);

                DGV1.DataSource = customeDataTable;
                //-----
                //-------------Replace Default Header Text with DataTable Columns Captions----------
                foreach (DataGridViewColumn n in DGV1.Columns)
                {
                    n.HeaderText = customeDataTable.Columns[n.Name].Caption;
                }
                //-----
                //----------Set Optional DGV1 Property----------
                DGV1.ColumnHeadersHeight = 80;
                //-----





            }
        }













        private void frmSellInvoiceRecords_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void DGV1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            _SellInvoiceCode = DGV1.Rows[e.RowIndex].Cells["SellInvoiceCode"].Value.ToString();

            this.DialogResult = DialogResult.OK;

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
                    ISelllnvoiceRepository selllnvoiceRepository = _UnitOfWork.SellInvoiceRepository;

                    string ShamsiDate = bPersianCalenderTextBox1.Text;
                    WorkWithDate workWithDate = new WorkWithDate();
                    DateTime MiladiDate = workWithDate.ShamsiToMiladi(ShamsiDate);



                    IEnumerable<SellInvoice> enumerableList = await selllnvoiceRepository.GetAll<SellInvoice>(n => n.SellInvoiceDate == MiladiDate);
                    List<SellInvoice> sellInvoices = new List<SellInvoice>(enumerableList);
                    DataTable customdatatable = DesignAndFillDataTable(sellInvoices);
                    DGV1.DataSource = customdatatable;






                }
            }
        }











        //-----------------------
    }
}
