using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces.IRepositories;
using Accounting.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
        async void LoadData()
        {
            using (UnitOfWork _UnitOfWork = new UnitOfWork())
            {
                IBuyInvoiceRepository buyInvoiceRepository = _UnitOfWork.BuyInvoiceRepository;
                //--------
                IEnumerable<BuyInvoice> IEnamrablebuyInvoiceDbRecords = await buyInvoiceRepository.GetAll<BuyInvoice>(n => n == n);
                List<BuyInvoice> DbbuyInvoicelist = IEnamrablebuyInvoiceDbRecords.ToList();


                //----------------------------------


                //-----
                DataTable dataTable = new DataTable();

                //-------Get MiladiDateTime List and Convert To ShamsiDate--------- 

                WorkWithDate workWithDate = new WorkWithDate();
                List<string> ShamsiDates = new List<string>();
                foreach (var n in DbbuyInvoicelist)
                {
                    ShamsiDates.Add(workWithDate.MiladiToShamsi(n.BuyInvoiceDate));
                }
                //-----
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


                dataTable.Columns["BuyInvoiceCode"].Caption = "کد فاکتور خرید";
                dataTable.Columns["BuyInvoiceDate"].Caption = " تاریخ فاکتور خرید";
                dataTable.Columns["BuyCount"].Caption = "تعداد خرید";
                dataTable.Columns["BuyPricePerUnit"].Caption = "قیمت خرید هر واحد";
                dataTable.Columns["Off"].Caption = "تخفیف";
                dataTable.Columns["TotalBuyAmount"].Caption = "کل قیمت خرید";
                dataTable.Columns["FKSeller"].Caption = "کد فروشنده";
                dataTable.Columns["FKStock"].Caption = "کد انبار";
                dataTable.Columns["Row"].Caption = "ردیف ";

                //-----
                //-------------seed data to dataTable---------
                for (int i = 0; i < DbbuyInvoicelist.Count; i++)
                {
                    DataRow dataRow = dataTable.NewRow();
                    dataRow["BuyInvoiceCode"] = DbbuyInvoicelist[i].BuyInvoiceCode;
                    dataRow["BuyCount"] = DbbuyInvoicelist[i].BuyCount;
                    dataRow["BuyPricePerUnit"] = DbbuyInvoicelist[i].BuyPricePerUnit;
                    dataRow["FKSeller"] = DbbuyInvoicelist[i].FKSeller;

                    dataRow["Off"] = DbbuyInvoicelist[i].Off;
                    dataRow["TotalBuyAmount"] = DbbuyInvoicelist[i].TotalBuyAmount;
                    dataRow["BuyInvoiceDate"] = ShamsiDates[i];
                    dataRow["FKStock"] = DbbuyInvoicelist[i].FKStock;
                    dataRow["Row"] = DbbuyInvoicelist[i].Row;
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
    }
}
