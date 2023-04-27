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
    public partial class frmCompanyRecords : Form
    {
        public frmCompanyRecords()
        {
            InitializeComponent();
        }

        private void frmCompanyRecords_Load(object sender, EventArgs e)
        {
            using (UnitOfWork _UnitOfWork = new UnitOfWork())
            {
                ICompanyRepository _CompanyRepository = _UnitOfWork.CompanyRepository;
                try
                {
                    DGV1.DataSource = _CompanyRepository.GetCompanyList();
                }
                catch
                {
                    MessageBox.Show(" خطایی رخ داده است");
                }

            }

        }
    }
}