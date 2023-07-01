using Accounting.DataLayer.Context;
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
    public partial class frmReturnFromSellIncoiceRecords : Form
    {
        public frmReturnFromSellIncoiceRecords()
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
        DataTable DesignAndFillDataTable(List<ReturnFromSellIncoice> DbReturnFromSellIncoicelist)
        {

            DataTable dataTable = new DataTable();
            //-----------Design datatable---------
            //----------- Create a DataTable and add 6 Columns to it---------
            //  DataTable dataTable = new DataTable();
            dataTable.Clear();
            dataTable.Columns.Add("FKCustomer", typeof(long));
            dataTable.Columns.Add("FKStock", typeof(int));
            dataTable.Columns.Add("ReturnFromSellIncoiceDate", typeof(string));
            dataTable.Columns.Add("FKSellInvoice", typeof(int));
            dataTable.Columns.Add("ReturnQuantity", typeof(int));
            dataTable.Columns.Add("ReturnFromSellIncoiceCode", typeof(string));
            dataTable.Columns.Add("TotalAmountFromReturnFromSellIncoice", typeof(decimal));

            dataTable.Columns["ReturnFromSellIncoiceCode"].Caption = "کد فاکتور بازگشت از فروش";
            dataTable.Columns["FKCustomer"].Caption = "کد مشتری";
            dataTable.Columns["FKStock"].Caption = " کد انبار";
            dataTable.Columns["ReturnFromSellIncoiceDate"].Caption = "تاریخ بازگشت از فروش";
            dataTable.Columns["FKSellInvoice"].Caption = "کد جدول سند فروش ";
            dataTable.Columns["ReturnQuantity"].Caption = "تعداد بازگشتی از فروش";
            dataTable.Columns["TotalAmountFromReturnFromSellIncoice"].Caption = "کل مبلغ برگشتی از فروش";

            //-----

            //--------------An Instanse to Store MildadiDates------------
            List<DateTime> MiladiDates = new List<DateTime>();
            //-----
            //-------Get MiladiDateTime List and Convert To ShamsiDate--------- 
            foreach (var n in DbReturnFromSellIncoicelist)
            {
                MiladiDates.Add(n.ReturnFromSellIncoiceDate);
            }
            WorkWithDate workWithDate = new WorkWithDate();
            List<string> ShamsiDates = new List<string>();
            foreach (var n in MiladiDates)
            {
                ShamsiDates.Add(workWithDate.MiladiToShamsi(n));
            }
            //-----
            //-------------seed data to dataTable---------
            for (int i = 0; i < DbReturnFromSellIncoicelist.Count; i++)
            {
                DataRow dataRow = dataTable.NewRow();
                dataRow["FKCustomer"] = DbReturnFromSellIncoicelist[i].FKCustomer;
                dataRow["FKStock"] = DbReturnFromSellIncoicelist[i].FKStock;
                dataRow["TotalAmountFromReturnFromSellIncoice"] = DbReturnFromSellIncoicelist[i].TotalAmountFromReturnFromSellIncoice;

                dataRow["FKSellInvoice"] = DbReturnFromSellIncoicelist[i].FKSellInvoice;
                dataRow["ReturnQuantity"] = DbReturnFromSellIncoicelist[i].ReturnQuantity;
                dataRow["ReturnFromSellIncoiceDate"] = ShamsiDates[i];
                dataRow["ReturnFromSellIncoiceCode"] = DbReturnFromSellIncoicelist[i].ReturnFromSellIncoiceCode;
                dataTable.Rows.Add(dataRow);

            }
            //-----
            return dataTable;

        }
        async void LoadData()
        {
            using (UnitOfWork _UnitOfWork = new UnitOfWork())
            {
                IReturnFromSellInvoiceRepository returnFromSellInvoiceRepository = _UnitOfWork.ReturnFromSellInvoicRepository;



                //---------Get List Of SellInvoice Table Records-----------
                IEnumerable<ReturnFromSellIncoice> DbEnabrableRecords = await returnFromSellInvoiceRepository.GetAll<ReturnFromSellIncoice>(n => n == n);
                List<ReturnFromSellIncoice> DbReturnFromSellIncoicelist = new List<ReturnFromSellIncoice>(DbEnabrableRecords);
                //-----

                //-------------Show In DGV1-----------
                DataTable customeDataTable = DesignAndFillDataTable(DbReturnFromSellIncoicelist);

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

                //-------------Replace Default Header Text with DataTable Columns Captions----------
                foreach (DataGridViewColumn n in DGV1.Columns)
                {
                    n.HeaderText = customeDataTable.Columns[n.Name].Caption;
                }
                //-----



            }
        }











        private void frmReturnFromSellIncoiceRecords_Load(object sender, EventArgs e)
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
                    IReturnFromSellInvoiceRepository returnFromSellInvoiceRepository = _UnitOfWork.ReturnFromSellInvoicRepository;

                    string ShamsiDate = bPersianCalenderTextBox1.Text;
                    WorkWithDate workWithDate = new WorkWithDate();
                    DateTime MiladiDate = workWithDate.ShamsiToMiladi(ShamsiDate);


                    IEnumerable<ReturnFromSellIncoice> enumerableCollection = await returnFromSellInvoiceRepository.GetAll<ReturnFromSellIncoice>(n => n.ReturnFromSellIncoiceDate == MiladiDate);
                    List<ReturnFromSellIncoice> ReturnFromSellInvoiceRecords = new List<ReturnFromSellIncoice>(enumerableCollection);
                    DataTable customdataTable = DesignAndFillDataTable(ReturnFromSellInvoiceRecords);
                    DGV1.DataSource = customdataTable;



                }
            }
        }



        async private void txtReturnFromSellInvoiceCode_TextChanged(object sender, EventArgs e)
        {
            if (txtReturnFromSellInvoiceCode.Text == "")
            {
                LoadData();
                return;
            }





            using (UnitOfWork _UnitOfWork = new UnitOfWork())
            {
                IReturnFromSellInvoiceRepository returnFromSellInvoiceRepository = _UnitOfWork.ReturnFromSellInvoicRepository;
                try
                {



                    IEnumerable<ReturnFromSellIncoice> returnFromSellIncoiceDbRecords = await returnFromSellInvoiceRepository.GetAll<ReturnFromSellIncoice>(n => n.ReturnFromSellIncoiceCode.ToString().Contains(txtReturnFromSellInvoiceCode.Text.ToString()));
                    List<ReturnFromSellIncoice> dblist = new List<ReturnFromSellIncoice>(returnFromSellIncoiceDbRecords);

                    DataTable datatable = DesignAndFillDataTable(dblist);


                    DGV1.DataSource = datatable;


                }
                catch
                {
                    MessageBox.Show(" خطایی رخ داده است");
                }


            }
        }


















        //------------------------------------
    }
}
