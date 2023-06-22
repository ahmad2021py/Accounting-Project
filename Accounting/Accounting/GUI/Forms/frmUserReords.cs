using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces.IRepositories;
using Accounting.Utilities;
using AccountingDLL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Accounting.GUI.Forms
{
    public partial class frmUserReords : Form
    {
        public frmUserReords()
        {
            InitializeComponent();
        }

        public string _id;
        public string _Role;
        public string _UserName;
        public string _Password;
        public string _UserCode;
        async void LoadData()
        {
            using (UnitOfWork _UnitOfWork = new UnitOfWork())
            {
                IUserRepository IUserRepository = _UnitOfWork.UserRepository;
                IEnumerable<User> DbUserList = await IUserRepository.GetAll<User>(n => n == n);
                foreach (User User in DbUserList)
                {
                    User.Password = WorkWithEncryption.DecryptPassword(User.Password);
                }


                DGV1.DataSource = DbUserList;

                DGV1.Columns["Row"].HeaderText = "ردیف";
                DGV1.Columns["UserCode"].HeaderText = " کد کاربر";
                DGV1.Columns["Role"].HeaderText = "نقش";
                DGV1.Columns["UserName"].HeaderText = " نام کاربری";
                DGV1.Columns["Password"].HeaderText = " کلمه عبور";
            }

        }

        private void frmLoginDetails_Load(object sender, EventArgs e)
        {
            LoadData();
        }









        private void frmUserReords_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void DGV1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            _Role = DGV1.Rows[e.RowIndex].Cells["Role"].Value.ToString();
            _UserCode = DGV1.Rows[e.RowIndex].Cells["UserCode"].Value.ToString();
            _UserName = DGV1.Rows[e.RowIndex].Cells["UserName"].Value.ToString();
            _Password = DGV1.Rows[e.RowIndex].Cells["Password"].Value.ToString();

            this.DialogResult = DialogResult.OK;
        }

      


        async private void txtRole_TextChanged(object sender, EventArgs e)
        {
            if (txtRole.Text == "")
            {
                LoadData();
                return;
            }

            using (UnitOfWork _UnitOfWork = new UnitOfWork())
            {
                IUserRepository _UserRepository = _UnitOfWork.UserRepository;

                IEnumerable<User> DbUserSearchRecords = await _UserRepository.GetAll<User>(n => n.Role == txtRole.Text);
                DGV1.DataSource = DbUserSearchRecords;


            }

        }

        private void btnExcelExport_Click(object sender, EventArgs e)
        {
            WorkWithExcel.ExportExcel(DGV1);
        }

      async  private void txtUserCode_TextChanged(object sender, EventArgs e)
        {
            if (txtUserCode.Text == "")
            {
                LoadData();
                return;
            }
           
            bool ValidationResult = WorkWithStrings.StringToIntValidations(txtUserCode.Text);
            if (!ValidationResult)
            {
                // MessageBox.Show("فیلد کد باید عددی صحیح باشد ");
                txtUserCode.Text = "";
                return;
            }
            using (UnitOfWork _UnitOfWork = new UnitOfWork())
            {
                IUserRepository _UserRepository = _UnitOfWork.UserRepository;
                int userCode =  int.Parse(txtUserCode.Text);  
                IEnumerable<User> DbUserSearchRecords = await _UserRepository.GetAll<User>(n => n.UserCode == userCode);


                DGV1.DataSource = DbUserSearchRecords;


            }
        }

       async private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                LoadData();
                return;
            }

            using (UnitOfWork _UnitOfWork = new UnitOfWork())
            {
                IUserRepository _UserRepository = _UnitOfWork.UserRepository;
                IEnumerable<User> DbUserSearchRecords = await _UserRepository.GetAll<User>(n => n.UserName == txtUserName.Text);


                DGV1.DataSource = DbUserSearchRecords;


            }
        }
















        //--------------------------------
    }
}
