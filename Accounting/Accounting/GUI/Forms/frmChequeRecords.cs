using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Accounting.GUI.Forms
{
    public partial class frmChequeRecords : Form
    {
        public frmChequeRecords()
        {
            InitializeComponent();
        }
        async void LoadData()
        {
            using (UnitOfWork _UnitOfWork = new UnitOfWork())
            {
                IChequeRepository chequeRepository = _UnitOfWork.ChequeRepository;
                //--------
                IEnumerable<Cheque> IEnamrableChequeDbRecords = await chequeRepository.GetAll<Cheque>(n => n == n);
                DGV1.DataSource = IEnamrableChequeDbRecords;
                DGV1.Columns["Row"].HeaderText = "ردیف";
                DGV1.Columns["ChequeCode"].HeaderText = "سریال چک";
                DGV1.Columns["Bank"].HeaderText = " بانک";
                DGV1.Columns["BankBranch"].HeaderText = " شعبه";
                DGV1.Columns["ChequeDate"].HeaderText = " تاریخ";
                DGV1.Columns["Amount"].HeaderText = " مبلغ";
                DGV1.Columns["Status"].HeaderText = "وضعیت";


                //----------------------------------


            }
        }
        private void frmChequeRecords_Load(object sender, EventArgs e)
        {
            LoadData();
        }


















        //----------------------------
    }
}
