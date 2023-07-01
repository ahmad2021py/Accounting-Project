using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces.IRepositories;
using Accounting.Utilities;
using Stimulsoft.Report;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Accounting.GUI.Forms
{
    public partial class frmBuyInvoiceRecords : Form
    {

        public string _Row;
        public string _BuyInvoiceCode;
        public string _BuyInvoiceDate;
        public string _BuyCount;
        public string _BuyPricePerUnit;
        public string _Off;
        public string _TotalBuyAmount;
        public string _FKSeller;
        public string _FKStock;
        private StiReport stiReport1;








        public frmBuyInvoiceRecords()
        {
            InitializeComponent();
            stiReport1 = new StiReport();
            // How to Activate Stimulsoft
            Stimulsoft.Base.StiLicense.Key = "6vJhGtLLLz2GNviWmUTrhSqnOItdDwjBylQzQcAOiHn0s4gy0Fr5YoUZ9V00Y0igCSFQzwEqYBh/N77k4f0fWXTHW5rqeBNLkaurJDenJ9o97TyqHs9HfvINK18Uwzsc/bG01Rq+x3H3Rf+g7AY92gvWmp7VA2Uxa30Q97f61siWz2dE5kdBVcCnSFzC6awE74JzDcJMj8OuxplqB1CYcpoPcOjKy1PiATlC3UsBaLEXsok1xxtRMQ283r282tkh8XQitsxtTczAJBxijuJNfziYhci2jResWXK51ygOOEbVAxmpflujkJ8oEVHkOA/CjX6bGx05pNZ6oSIu9H8deF94MyqIwcdeirCe60GbIQByQtLimfxbIZnO35X3fs/94av0ODfELqrQEpLrpU6FNeHttvlMc5UVrT4K+8lPbqR8Hq0PFWmFrbVIYSi7tAVFMMe2D1C59NWyLu3AkrD3No7YhLVh7LV0Tttr/8FrcZ8xirBPcMZCIGrRIesrHxOsZH2V8t/t0GXCnLLAWX+TNvdNXkB8cF2y9ZXf1enI064yE5dwMs2fQ0yOUG/xornE";
            //Stimulsoft.Base.StiLicense.LoadFromFile("license.key");
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

        private void btnExport_Click(object sender, EventArgs e)
        {
            //Load File
            stiReport1.Load(Application.StartupPath + "/AppFiles/BuyInvoice.mrt");
            stiReport1.Compile();
            //Set Variables
            stiReport1["Row"] = _Row;
            stiReport1["BuyInvoiceCode"] = _BuyInvoiceCode;
            stiReport1["BuyInvoiceDate"] = _BuyInvoiceDate;
            stiReport1["FKStock"] = _FKStock;
            stiReport1["FKSeller"] = _FKSeller;
            stiReport1["TotalBuyAmount"] = _TotalBuyAmount;
            stiReport1["Off"] = _Off;
            stiReport1["BuyPricePerUnit"] = _BuyPricePerUnit;
            stiReport1["BuyCount"] = _BuyCount;



            //--------Show------------
            stiReport1.Show();
            //---------
        }

        private void DGV1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _Row = DGV1.Rows[e.RowIndex].Cells["Row"].Value.ToString();
            _BuyCount = DGV1.Rows[e.RowIndex].Cells["BuyCount"].Value.ToString();
            _BuyInvoiceCode = DGV1.Rows[e.RowIndex].Cells["BuyInvoiceCode"].Value.ToString();
            _BuyInvoiceDate = DGV1.Rows[e.RowIndex].Cells["BuyInvoiceDate"].Value.ToString();
            _BuyPricePerUnit = DGV1.Rows[e.RowIndex].Cells["BuyPricePerUnit"].Value.ToString();
            _FKSeller = DGV1.Rows[e.RowIndex].Cells["FKSeller"].Value.ToString();
            _FKStock = DGV1.Rows[e.RowIndex].Cells["FKStock"].Value.ToString();
            _Off = DGV1.Rows[e.RowIndex].Cells["Off"].Value.ToString();
            _TotalBuyAmount = DGV1.Rows[e.RowIndex].Cells["TotalBuyAmount"].Value.ToString();
        }

        async private void txtBuyInvoiceCode_TextChanged(object sender, EventArgs e)
        {
            if (txtBuyInvoiceCode.Text == "")
            {
                LoadData();
                return;
            }





            using (UnitOfWork _UnitOfWork = new UnitOfWork())
            {
                IBuyInvoiceRepository buyInvoiceRepository = _UnitOfWork.BuyInvoiceRepository;
                try
                {


                    long buyInvoiceCode = long.Parse(txtBuyInvoiceCode.Text);
                    var buyInvoiceDbRecords = await buyInvoiceRepository.GetAll<BuyInvoice>(n => n.BuyInvoiceCode.ToString().Contains(txtBuyInvoiceCode.Text.ToString()));
                    DGV1.DataSource = buyInvoiceDbRecords;


                }
                catch
                {
                    MessageBox.Show(" خطایی رخ داده است");
                }


            }
        }
















        //----------------------------
    }
}
