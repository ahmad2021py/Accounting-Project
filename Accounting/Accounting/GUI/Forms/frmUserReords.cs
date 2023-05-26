using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces;
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

        void LoadData()
        {
            using (UnitOfWork _UnitOfWork = new UnitOfWork())
            {
                IUserRepository IUserRepository = _UnitOfWork.UserRepository;
                DGV1.DataSource = IUserRepository.GetAll<User>(n=>n==n);
                DGV1.Columns[0].HeaderText = " نقش";
                DGV1.Columns[1].HeaderText = "آیدی";
                DGV1.Columns[2].HeaderText = " نام کاربری";
                DGV1.Columns[3].HeaderText = " کلمه عبور";
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

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {
            if (txtUserID.Text == "")
            {
                LoadData();
            }
            else
            {
                using (UnitOfWork _UnitOfWork = new UnitOfWork())
                {
                    IUserRepository _UserRepository = _UnitOfWork.UserRepository;
                    try
                    {
                        int id = Convert.ToInt32(txtUserID.Text);
                        DGV1.DataSource = _UserRepository.GetAll<User>(n=>n.id==id);

                    }
                    catch
                    {
                        MessageBox.Show(" خطایی رخ داده است");
                    }
                }
            }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                LoadData();
            }
            else
            {
                using (UnitOfWork _UnitOfWork = new UnitOfWork())
                {
                    IUserRepository _UserRepository = _UnitOfWork.UserRepository;
                    try
                    {
                      
                        DGV1.DataSource = _UserRepository.GetAll<User>(n=>n.UserName==txtUserName.Text);

                    }
                    catch
                    {
                        MessageBox.Show(" خطایی رخ داده است");
                    }
                }
            }
        }

        private void txtRole_TextChanged(object sender, EventArgs e)
        {
            if (txtRole.Text == "")
            {
                LoadData();
            }
            else
            {
                using (UnitOfWork _UnitOfWork = new UnitOfWork())
                {
                    IUserRepository _UserRepository = _UnitOfWork.UserRepository;
                    try
                    {
                        DGV1.DataSource = _UserRepository.GetAll<User>(n=>n.Role==txtRole.Text);

                    }
                    catch
                    {
                        MessageBox.Show(" خطایی رخ داده است");
                    }
                }
            }
        }
    }
}
