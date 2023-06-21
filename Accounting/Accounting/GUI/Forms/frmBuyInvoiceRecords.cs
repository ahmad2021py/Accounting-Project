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
    public partial class frmBuyInvoiceRecords : Form
    {

        public string _BuyInvoiceCode;
        public string _FKStock;
        public frmBuyInvoiceRecords()
        {
            InitializeComponent();
        }


        private DataTable DesignAndFillDataTable(List<BuyInvoice> BuyInvoiceRecords)
        {
            DataTable dataTable = new DataTable();
            //-----------Design datatable---------
            //----------- Create a DataTable and add 6 Columns to it---------
            //  DataTable dataTable = new DataTable();
            dataTable.Clear();
            dataTable.Columns.Add("Row", typeof(int));
            dataTable.Columns.Add("BuyInvoiceCode", typeof(string));
            dataTable.Columns.Add("BuyInvoiceDate", typeof(string));
            dataTable.Columns.Add("BuyCount", typeof(int));
            dataTable.Columns.Add("BuyPricePerUnit", typeof(decimal));
            dataTable.Columns.Add("Off", typeof(int));
            dataTable.Columns.Add("TotalBuyAmount", typeof(decimal));
            dataTable.Columns.Add("FKSeller", typeof(long));
            dataTable.Columns.Add("FKStock", typeof(int));


            dataTable.Columns["Row"].Caption = "ردیف ";
            dataTable.Columns["BuyInvoiceCode"].Caption = "کد فاکتور";
            dataTable.Columns["BuyInvoiceDate"].Caption = "تاریخ فاکتور";
            dataTable.Columns["BuyCount"].Caption = "تعداد خرید";
            dataTable.Columns["BuyPricePerUnit"].Caption = "قیمت هر واحد";
            dataTable.Columns["Off"].Caption = "تخفیف";
            dataTable.Columns["TotalBuyAmount"].Caption = "کل مبلغ خرید";
            dataTable.Columns["FKSeller"].Caption = "کد فروشنده";
            dataTable.Columns["FKStock"].Caption = "کد انبار";



            //-----

            //--------------An Instanse to Store MildadiDates------------
            List<DateTime> MiladiDates = new List<DateTime>();
            //-----
            //-------Get MiladiDateTime List and Convert To ShamsiDate--------- 
            foreach (var n in BuyInvoiceRecords)
            {
                MiladiDates.Add(n.BuyInvoiceDate);
            }
            WorkWithDate workWithDate = new WorkWithDate();
            List<string> ShamsiDates = new List<string>();
            foreach (var n in MiladiDates)
            {
                ShamsiDates.Add(workWithDate.MiladiToShamsi(n));
            }
            //-----
            //-------------seed data to dataTable---------
            for (int i = 0; i < BuyInvoiceRecords.Count; i++)
            {
                DataRow dataRow = dataTable.NewRow();
                dataRow["Row"] = BuyInvoiceRecords[i].Row;
                dataRow["FKStock"] = BuyInvoiceRecords[i].FKStock;
                dataRow["FKSeller"] = BuyInvoiceRecords[i].FKSeller;
                dataRow["TotalBuyAmount"] = BuyInvoiceRecords[i].TotalBuyAmount;
                dataRow["Off"] = BuyInvoiceRecords[i].Off;
                dataRow["BuyPricePerUnit"] = BuyInvoiceRecords[i].BuyPricePerUnit;
                dataRow["BuyCount"] = BuyInvoiceRecords[i].BuyCount;
                dataRow["BuyInvoiceDate"] = ShamsiDates[i];
                dataRow["BuyInvoiceCode"] = BuyInvoiceRecords[i].BuyInvoiceCode;

                dataTable.Rows.Add(dataRow);

            }
            //-----
            return dataTable;
        }
        async void LoadData()
        {


            using (UnitOfWork _UnitOfWork = new UnitOfWork())
            {
                IBuyInvoiceRepository buyInvoiceRepository = _UnitOfWork.BuyInvoiceRepository;
                //--------


                //--------

                IEnumerable<BuyInvoice> IEnamrableChequeDbRecords = await buyInvoiceRepository.GetAll<BuyInvoice>(n => n == n);
                List<BuyInvoice> DbChequelist = new List<BuyInvoice>(IEnamrableChequeDbRecords);
                //-----




                //--------Fill DataTable-----------
                DataTable customeDataTable = DesignAndFillDataTable(DbChequelist);
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
 

        private void frmBuyInvoiceRecords_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void DGV1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _BuyInvoiceCode = DGV1.Rows[e.RowIndex].Cells["BuyInvoiceCode"].Value.ToString();
            _FKStock = DGV1.Rows[e.RowIndex].Cells["FKStock"].Value.ToString();

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
                    IBuyInvoiceRepository buyInvoiceRepository = _UnitOfWork.BuyInvoiceRepository;

                    string ShamsiDate = bPersianCalenderTextBox1.Text;
                    WorkWithDate workWithDate = new WorkWithDate();
                    DateTime MiladiDate = workWithDate.ShamsiToMiladi(ShamsiDate);


                    IEnumerable<BuyInvoice> enumerableCollection = await buyInvoiceRepository.GetAll<BuyInvoice>(n => n.BuyInvoiceDate == MiladiDate);
                    List<BuyInvoice> BuyInvoiceRecords = new List<BuyInvoice>(enumerableCollection);
                    DataTable customdataTable = DesignAndFillDataTable(BuyInvoiceRecords);
                    DGV1.DataSource = customdataTable;



                }
            }


        }
















            //----------------------------
    }
}
