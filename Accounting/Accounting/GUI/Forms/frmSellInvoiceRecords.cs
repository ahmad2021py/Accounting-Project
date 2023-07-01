using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces.IRepositories;
using Accounting.Utilities;
using Stimulsoft.Report;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Accounting.GUI.Forms
{
    public partial class frmSellInvoiceRecords : Form
    {
        public string _SellInvoiceCode;
        public string _Row;
        public string _SellInvoiceDate;
        public string _FKCustomer;
        public string _FKStock;
        public string _Quantity;
        public string _TotalSellAmount;
        public string _SellPricePerUnit;
        public string _Off;
        private StiReport stiReport1;
        public frmSellInvoiceRecords()
        {
            InitializeComponent();
            stiReport1 = new StiReport();
            // How to Activate Stimulsoft
            Stimulsoft.Base.StiLicense.Key = "6vJhGtLLLz2GNviWmUTrhSqnOItdDwjBylQzQcAOiHn0s4gy0Fr5YoUZ9V00Y0igCSFQzwEqYBh/N77k4f0fWXTHW5rqeBNLkaurJDenJ9o97TyqHs9HfvINK18Uwzsc/bG01Rq+x3H3Rf+g7AY92gvWmp7VA2Uxa30Q97f61siWz2dE5kdBVcCnSFzC6awE74JzDcJMj8OuxplqB1CYcpoPcOjKy1PiATlC3UsBaLEXsok1xxtRMQ283r282tkh8XQitsxtTczAJBxijuJNfziYhci2jResWXK51ygOOEbVAxmpflujkJ8oEVHkOA/CjX6bGx05pNZ6oSIu9H8deF94MyqIwcdeirCe60GbIQByQtLimfxbIZnO35X3fs/94av0ODfELqrQEpLrpU6FNeHttvlMc5UVrT4K+8lPbqR8Hq0PFWmFrbVIYSi7tAVFMMe2D1C59NWyLu3AkrD3No7YhLVh7LV0Tttr/8FrcZ8xirBPcMZCIGrRIesrHxOsZH2V8t/t0GXCnLLAWX+TNvdNXkB8cF2y9ZXf1enI064yE5dwMs2fQ0yOUG/xornE";
            //Stimulsoft.Base.StiLicense.LoadFromFile("license.key");

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

        private void btnExport_Click(object sender, EventArgs e)
        {
            //Load File
            stiReport1.Load(Application.StartupPath + "/AppFiles/SellInvoice.mrt");
            stiReport1.Compile();
            //Set Variables
            stiReport1["Row"] = _Row;
            stiReport1["SellInvoiceCode"] = _SellInvoiceCode;
            stiReport1["SellInvoiceDate"] = _SellInvoiceDate;
            stiReport1["FKStock"] = _FKStock;
            stiReport1["FKCustomer"] = _FKCustomer;
            stiReport1["TotalSellAmount"] = _TotalSellAmount;
            stiReport1["Off"] = _Off;
            stiReport1["SellPricePerUnit"] = _SellPricePerUnit;
            stiReport1["Quantity"] = _Quantity;
            //--------Show------------
            stiReport1.Show();
            //-----
        }

        private void DGV1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _Row = DGV1.Rows[e.RowIndex].Cells["Row"].Value.ToString();
            _Quantity = DGV1.Rows[e.RowIndex].Cells["Quantity"].Value.ToString();
            _FKCustomer = DGV1.Rows[e.RowIndex].Cells["FKCustomer"].Value.ToString();
            _FKStock = DGV1.Rows[e.RowIndex].Cells["FKStock"].Value.ToString();
            _Off = DGV1.Rows[e.RowIndex].Cells["Off"].Value.ToString();
            _SellInvoiceCode = DGV1.Rows[e.RowIndex].Cells["SellInvoiceCode"].Value.ToString();
            _SellInvoiceDate = DGV1.Rows[e.RowIndex].Cells["SellInvoiceDate"].Value.ToString();
            _SellPricePerUnit = DGV1.Rows[e.RowIndex].Cells["SellPricePerUnit"].Value.ToString();
            _TotalSellAmount = DGV1.Rows[e.RowIndex].Cells["TotalSellAmount"].Value.ToString();
        }

        async private void txtSellInvoiceCode_TextChanged(object sender, EventArgs e)
        {
            if (txtSellInvoiceCode.Text == "")
            {
                LoadData();
                return;
            }





            using (UnitOfWork _UnitOfWork = new UnitOfWork())
            {
                ISelllnvoiceRepository selllnvoiceRepository = _UnitOfWork.SellInvoiceRepository;
                try
                {



                    IEnumerable<SellInvoice> sellIncoiceDbRecords = await selllnvoiceRepository.GetAll<SellInvoice>(n => n.SellInvoiceCode.ToString().Contains(txtSellInvoiceCode.Text.ToString()));
                    List<SellInvoice> dblist = new List<SellInvoice>(sellIncoiceDbRecords);

                    DataTable datatable = DesignAndFillDataTable(dblist);


                    DGV1.DataSource = datatable;


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
