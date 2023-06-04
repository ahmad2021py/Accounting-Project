using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces.IRepositories;
using Accounting.Utilities;
using AccountingDLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Accounting.GUI.Forms
{
    public partial class frmStockRecords : Form
    {
        DataTable dataTable;
        public frmStockRecords()
        {
            InitializeComponent();
            dataTable = new DataTable();
        }


        public string _StockCode;
        public string _FKProductId;
        public string _BuyPrice;
        public string _StockDate;
        public string _Quantity;
        public string _Description;

        async void LoadData()
        {
            using (UnitOfWork _UnitOfWork = new UnitOfWork())
            {
                IStockRepository StockRepository = _UnitOfWork.StockRepository;


                //---------Get List Of Stock Table Records-----------
                IEnumerable<Stock> EnumerableStocklist = await StockRepository.GetAll<Stock>(n => n == n);
                List<Stock> DbStocklist = new List<Stock>(EnumerableStocklist);
                //-----
                //--------------An Instanse to Store MildadiDates------------
                List<DateTime> MiladiDates = new List<DateTime>();
                //-----
                //-------Get MiladiDateTime List and Convert To ShamsiDate--------- 
                foreach (var n in DbStocklist)
                {
                    MiladiDates.Add(n.StockDate);
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
                dataTable.Columns.Add("StockCode", typeof(int));
                dataTable.Columns.Add("Description", typeof(string));
                dataTable.Columns.Add("Quantity", typeof(string));
                dataTable.Columns.Add("StockDate", typeof(string));
                dataTable.Columns.Add("BuyPrice", typeof(int));
                dataTable.Columns.Add("FKProductId", typeof(long));
                dataTable.Columns["StockCode"].Caption = " کد انبار";
                dataTable.Columns["Description"].Caption = " توضیحات";
                dataTable.Columns["Quantity"].Caption = " تعداد";
                dataTable.Columns["StockDate"].Caption = " تاریخ دریافت";
                dataTable.Columns["BuyPrice"].Caption = "قیمت خرید  هر واحد";
                dataTable.Columns["FKProductId"].Caption = " کد کالا";
                //-----
                //-------------seed data to dataTable---------
                for (int i = 0; i < DbStocklist.Count; i++)
                {
                    DataRow dataRow = dataTable.NewRow();
                    dataRow["StockCode"] = DbStocklist[i].StockCode;
                    dataRow["BuyPrice"] = DbStocklist[i].StockCode;
                    dataRow["Description"] = DbStocklist[i].Description;
                    dataRow["Quantity"] = DbStocklist[i].Quantity;
                    dataRow["StockDate"] = ShamsiDates[i];
                    dataRow["FKProductId"] = DbStocklist[i].FKProduct;
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
                //----------Set Optional DGV1 Property----------
                DGV1.ColumnHeadersHeight = 80;
                //-----





            }
        }

        private void frmStockRecords_Load(object sender, EventArgs e)
        {
            LoadData();
        }





        private void btnSearchByDate_Click(object sender, EventArgs e)
        {
            if (bPersianCalenderTextBox1.Text == "")
            {
                LoadData();
            }
            else
            {
                using (UnitOfWork _UnitOfWork = new UnitOfWork())
                {
                    IStockRepository _StockRepository = _UnitOfWork.StockRepository;
                    //try
                    //{




                    string ShamsiDate = bPersianCalenderTextBox1.Text;
                    WorkWithDate workWithDate = new WorkWithDate();
                    DateTime MiladiDate = workWithDate.ShamsiToMiladi(ShamsiDate);



                    DGV1.DataSource = _StockRepository.GetAll<Stock>(n => n.StockDate == MiladiDate);
                    DGV1.Columns["Product"].Visible = false;

                    //}
                    //catch
                    //{
                    //    MessageBox.Show(" خطایی رخ داده است");
                    //}

                }
            }
        }


        private void frmStockRecords_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }



        private void txtStockId_TextChanged(object sender, EventArgs e)
        {

            bool ValidationResult = WorkWithStrings.StringToIntValidations(txtStockCode.Text);
            if (!ValidationResult)
            {
                // MessageBox.Show("فیلد کد باید عددی صحیح باشد ");
                txtStockCode.Text = "";
                return;
            }
            if (txtStockCode.Text == "")
            {
                LoadData();
            }
            else
            {
                using (UnitOfWork _UnitOfWork = new UnitOfWork())
                {
                    IStockRepository _StockRepository = _UnitOfWork.StockRepository;


                    long StockCode = long.Parse(txtStockCode.Text);
                    DGV1.DataSource = _StockRepository.GetAll<Stock>(n => n.StockCode == StockCode);




                }
            }
        }

        private void txtProductId_TextChanged(object sender, EventArgs e)
        {
            bool ValidationResult = WorkWithStrings.StringToIntValidations(txtProductCode.Text);
            if (!ValidationResult)
            {
                // MessageBox.Show("فیلد کد باید عددی صحیح باشد ");
                txtProductCode.Text = "";
                return;
            }
            if (txtProductCode.Text == "")
            {
                LoadData();
            }
            else
            {
                using (UnitOfWork _UnitOfWork = new UnitOfWork())
                {
                    IProductRepository _ProductRepository = _UnitOfWork.ProductRepository;


                    long ProductCode = long.Parse(txtProductCode.Text);
                    DGV1.DataSource = _ProductRepository.GetAll<Stock>(n => n.FKProduct == ProductCode);
                    //DGV1.Columns["Product"].Visible = false;



                }
            }
        }

        private void btnExcelExport_Click(object sender, EventArgs e)
        {
            WorkWithExcel.ExportExcel(DGV1);
        }

        private void DGV1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            _StockCode = DGV1.Rows[e.RowIndex].Cells["StockCode"].Value.ToString();
            _FKProductId = DGV1.Rows[e.RowIndex].Cells["FKProductId"].Value.ToString();
            _Quantity = DGV1.Rows[e.RowIndex].Cells["Quantity"].Value.ToString();
            _Description = DGV1.Rows[e.RowIndex].Cells["Description"].Value.ToString();
            _BuyPrice = DGV1.Rows[e.RowIndex].Cells["BuyPrice"].Value.ToString();
            _StockDate = DGV1.Rows[e.RowIndex].Cells["StockDate"].Value.ToString();

            this.DialogResult = DialogResult.OK;
        }




























        //------------------------------------
    }
}
