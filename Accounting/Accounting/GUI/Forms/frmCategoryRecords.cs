using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
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
    public partial class frmCategoryRecords : Form
    {
        public frmCategoryRecords()
        {
            InitializeComponent();
        }

        private  void frmCategoryRecords_Load(object sender, EventArgs e)
        {
           
            using (UnitOfWork _UnitOfWork = new UnitOfWork())
            {
                ICategoryRepository _CategoryRepository = _UnitOfWork.CategoryRepository;
                try
                {
                    DGV1.DataSource = _CategoryRepository.GetAll<Categories>(n=>n==n);
                    DGV1.Columns[0].HeaderText = " کد دسته بندی";
                    DGV1.Columns[1].HeaderText = " نام دسته بندی";
                }
                catch
                {
                    MessageBox.Show(" خطایی رخ داده است");
                }

            }
        }
    }
}
