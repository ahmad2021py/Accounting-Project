using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces;
using Accounting.Utilities;
using AccountingDLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting.GUI.Forms
{
    public partial class frmUserReords : Form
    {
        public frmUserReords()
        {
            InitializeComponent();
        }

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
                DGV1.Columns["id"].HeaderText = " آیدی";
                DGV1.Columns["Role"].HeaderText = "نقش";
                DGV1.Columns["UserName"].HeaderText = " نام کاربری";
                DGV1.Columns["Password"].HeaderText = " کلمه عبور";
            }

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmLoginDetails_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            WorkWithExcel.ExportExcel(DGV1);
        }

        private async void txtProductName_TextChanged(object sender, EventArgs e)
        {
            if (txtUserID.Text == "")
            {
                LoadData();
                return;

            }
            bool ValidationResult = WorkWithStrings.TextToIntVlaidation(txtUserID.Text);
            if (!ValidationResult)
            {
                // MessageBox.Show("فیلد کد باید عددی صحیح باشد ");
                txtUserID.Text = "";
                return;
            }

            using (UnitOfWork _UnitOfWork = new UnitOfWork())
            {
                IUserRepository _UserRepository = _UnitOfWork.UserRepository;
                try
                {
                    int id = Convert.ToInt32(txtUserID.Text);
                    IEnumerable<User> DbUserSearchRecords = await _UserRepository.GetAll<User>(n => n.id == id);
                    DGV1.DataSource = DbUserSearchRecords;

                }
                catch
                {
                    MessageBox.Show(" خطایی رخ داده است");
                }
            }

        }

        private async void txtUserName_TextChanged(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                LoadData();
                return;
            }

            using (UnitOfWork _UnitOfWork = new UnitOfWork())
            {
                IUserRepository _UserRepository = _UnitOfWork.UserRepository;
                try
                {
                    IEnumerable<User> DbUserSearchRecords = await _UserRepository.GetAll<User>(n => n.UserName == txtUserName.Text);
                    DGV1.DataSource = DbUserSearchRecords;

                }
                catch
                {
                    MessageBox.Show(" خطایی رخ داده است");
                }
            }

        }

        private async void txtRole_TextChanged(object sender, EventArgs e)
        {
            if (txtRole.Text == "")
            {
                LoadData();
                return;
            }

            using (UnitOfWork _UnitOfWork = new UnitOfWork())
            {
                IUserRepository _UserRepository = _UnitOfWork.UserRepository;
                try
                {
                    IEnumerable<User> DbUserSearchRecords = await _UserRepository.GetAll<User>(n => n.Role == txtRole.Text);
                    DGV1.DataSource = DbUserSearchRecords;

                }
                catch
                {
                    MessageBox.Show(" خطایی رخ داده است");
                }
            }

        }

        private void frmUserReords_FormClosed(object sender, FormClosedEventArgs e)
        {
          
            this.Hide();
        }

        private void frmUserReords_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }













        //--------------------------------
    }
}
