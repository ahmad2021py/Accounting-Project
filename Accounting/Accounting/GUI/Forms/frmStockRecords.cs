using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces;
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


        void LoadData()
        {
            using (UnitOfWork _UnitOfWork = new UnitOfWork())
            {
                IStockRepository StockRepository = _UnitOfWork.StockRepository;
                try
                {

                    //---------Get List Of Stock Table Records-----------
                    var list = StockRepository.GetAll<Stock>(n => n == n);
                    //-----
                    //--------------An Instanse to Store MildadiDates------------
                    List<DateTime> MiladiDates = new List<DateTime>();
                    //-----
                    //-------Get MiladiDateTime List and Convert To ShamsiDate--------- 
                    foreach (var n in list)
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
                    dataTable.Columns.Add("id", typeof(int));
                    dataTable.Columns.Add("Description", typeof(string));
                    dataTable.Columns.Add("Quantity", typeof(string));
                    dataTable.Columns.Add("StockDate", typeof(string));
                    dataTable.Columns.Add("BuyPrice", typeof(int));
                    dataTable.Columns.Add("FKProductId", typeof(long));
                    dataTable.Columns["id"].Caption = " کد انبار";
                    dataTable.Columns["Description"].Caption = " توضیحات";
                    dataTable.Columns["Quantity"].Caption = " تعداد";
                    dataTable.Columns["StockDate"].Caption = " تاریخ دریافت";
                    dataTable.Columns["BuyPrice"].Caption = "قیمت خرید  هر واحد";
                    dataTable.Columns["FKProductId"].Caption = " کد کالا";
                    //-----
                    //-------------seed data to dataTable---------
                    for (int i = 0; i < list.Count; i++)
                    {
                        DataRow dataRow = dataTable.NewRow();
                        dataRow["id"] = list[i].id;
                        dataRow["Description"] = list[i].Description;
                        dataRow["Quantity"] = list[i].Quantity;
                        dataRow["StockDate"] = ShamsiDates[i];
                        dataRow["BuyPrice"] = list[i].BuyPrice;
                        dataRow["FKProductId"] = list[i].FKProductId;
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
                catch
                {
                    MessageBox.Show(" خطایی رخ داده است");
                }
            }
        }

        private void frmStockRecords_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            WorkWithExcel.ExportExcel(DGV1);
        }

        private void txtStockId_TextChanged(object sender, EventArgs e)
        {
           
            bool ValidationResult = WorkWithStrings.TextToIntVlaidation(txtStockId.Text);
            if (!ValidationResult)
            {
                // MessageBox.Show("فیلد کد باید عددی صحیح باشد ");
                txtStockId.Text = "";
                return;
            }
            if (txtStockId.Text == "")
            {
                LoadData();
            }


            else
            {
                using (UnitOfWork _UnitOfWork = new UnitOfWork())
                {
                    IStockRepository _StockRepository = _UnitOfWork.StockRepository;
                    try
                    {


                        long StockId = long.Parse(txtStockId.Text);
                        DGV1.DataSource = _StockRepository.GetAll<Stock>(n => n.id == StockId);
                        DGV1.Columns["Product"].Visible = false;

                    }
                    catch
                    {
                        MessageBox.Show(" خطایی رخ داده است");
                    }

                }
            }
        }

        private void txtProductId_TextChanged(object sender, EventArgs e)
        {
          

            bool ValidationResult = WorkWithStrings.TextToIntVlaidation(txtProductId.Text);
            if (!ValidationResult)
            {
                // MessageBox.Show("فیلد کد باید عددی صحیح باشد ");
                txtProductId.Text = "";
                return;
            }
            if (txtProductId.Text == "")
            {
                LoadData();
            }
            else
            {
                using (UnitOfWork _UnitOfWork = new UnitOfWork())
                {
                    IProductRepository _ProductRepository = _UnitOfWork.ProductRepository;
                    try
                    {


                        long ProductId = long.Parse(txtProductId.Text);
                        DGV1.DataSource = _ProductRepository.GetAll<Stock>(n => n.FKProductId == ProductId);
                        DGV1.Columns["Product"].Visible = false;

                    }
                    catch
                    {
                        MessageBox.Show(" خطایی رخ داده است");
                    }

                }
            }
        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {

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



























        //------------------------------------
    }
}
