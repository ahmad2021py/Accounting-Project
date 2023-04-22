using Accounting.DataLayer.Context;
using Accounting.DataLayer.Interfaces;
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
    public partial class frmLoginDetails : Form
    {
        public frmLoginDetails()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmLoginDetails_Load(object sender, EventArgs e)
        {
            using(UnitOfWork _UnitOfWork=new UnitOfWork())
            {
                IUserRepository IUserRepository = _UnitOfWork.UserRepository;
                dataGridView1.DataSource = IUserRepository.GetUserList();
            }
          
        }
    }
}
