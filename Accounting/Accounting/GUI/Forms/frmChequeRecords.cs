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
    public partial class frmChequeRecords : Form
    {
        public frmChequeRecords()
        {
            InitializeComponent();
        }

        private DataTable DesignAndFillDataTable(List<Cheque> ChequeRecords)
        {
            DataTable dataTable = new DataTable();
            //-----------Design datatable---------
            //----------- Create a DataTable and add 6 Columns to it---------
            //  DataTable dataTable = new DataTable();
            dataTable.Clear();
            dataTable.Columns.Add("Row", typeof(int));
            dataTable.Columns.Add("Status", typeof(string));
            dataTable.Columns.Add("Amount", typeof(decimal));
            dataTable.Columns.Add("ChequeDate", typeof(string));
            dataTable.Columns.Add("BankBranch", typeof(string));
            dataTable.Columns.Add("Bank", typeof(string));
            dataTable.Columns.Add("ChequeCode", typeof(string));


            dataTable.Columns["Row"].Caption = "ردیف ";
            dataTable.Columns["Status"].Caption = "وضعیت";
            dataTable.Columns["Amount"].Caption = "مبلغ";
            dataTable.Columns["ChequeDate"].Caption = "تاریخ چک";
            dataTable.Columns["BankBranch"].Caption = "شعبه";
            dataTable.Columns["Bank"].Caption = "بانک";
            dataTable.Columns["ChequeCode"].Caption = "سریال چک";



            //-----

            //--------------An Instanse to Store MildadiDates------------
            List<DateTime> MiladiDates = new List<DateTime>();
            //-----
            //-------Get MiladiDateTime List and Convert To ShamsiDate--------- 
            foreach (var n in ChequeRecords)
            {
                MiladiDates.Add(n.ChequeDate);
            }
            WorkWithDate workWithDate = new WorkWithDate();
            List<string> ShamsiDates = new List<string>();
            foreach (var n in MiladiDates)
            {
                ShamsiDates.Add(workWithDate.MiladiToShamsi(n));
            }
            //-----
            //-------------seed data to dataTable---------
            for (int i = 0; i < ChequeRecords.Count; i++)
            {
                DataRow dataRow = dataTable.NewRow();
                dataRow["Row"] = ChequeRecords[i].Row;
                dataRow["ChequeCode"] = ChequeRecords[i].ChequeCode;
                dataRow["Bank"] = ChequeRecords[i].Bank;
                dataRow["ChequeDate"] = ShamsiDates[i];
                dataRow["BankBranch"] = ChequeRecords[i].BankBranch;
                dataRow["Amount"] = ChequeRecords[i].Amount;
                dataRow["Status"] = ChequeRecords[i].Status;
   
                dataTable.Rows.Add(dataRow);

            }
            //-----
            return dataTable;
        }
        async void LoadData()
        {


            using (UnitOfWork _UnitOfWork = new UnitOfWork())
            {
                IChequeRepository chequeRepository = _UnitOfWork.ChequeRepository;
                //--------


                //--------

                IEnumerable<Cheque> IEnamrableChequeDbRecords = await chequeRepository.GetAll<Cheque>(n => n == n);
                List<Cheque> DbChequelist = new List<Cheque>(IEnamrableChequeDbRecords);
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





       
        private void frmChequeRecords_Load(object sender, EventArgs e)
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
                    IChequeRepository chequeRepository = _UnitOfWork.ChequeRepository;

                    string ShamsiDate = bPersianCalenderTextBox1.Text;
                    WorkWithDate workWithDate = new WorkWithDate();
                    DateTime MiladiDate = workWithDate.ShamsiToMiladi(ShamsiDate);


                    IEnumerable<Cheque> enumerableCollection = await chequeRepository.GetAll<Cheque>(n => n.ChequeDate == MiladiDate);
                    List<Cheque> ChequeRecords = new List<Cheque>(enumerableCollection);
                    DataTable customdataTable = DesignAndFillDataTable(ChequeRecords);
                    DGV1.DataSource = customdataTable;



                }

            }

        }

      async  private void txtChequeCode_TextChanged(object sender, EventArgs e)
        {
            if (txtChequeCode.Text == "")
            {
                LoadData();
                return;
            }





            using (UnitOfWork _UnitOfWork = new UnitOfWork())
            {
                IChequeRepository chequeRepository = _UnitOfWork.ChequeRepository;
                try
                {


              
                    var chequeDbRecords = await chequeRepository.GetAll<Cheque>(n => n.ChequeCode.ToString().Contains(txtChequeCode.Text.ToString()));
                    DGV1.DataSource = chequeDbRecords;


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
