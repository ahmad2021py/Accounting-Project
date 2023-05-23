using Accounting.DataLayer.Context;
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
    public partial class frmCustomerRecords : Form
    {
        public frmCustomerRecords()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            using (UnitOfWork _UnitOfWork = new UnitOfWork())
            {
                ICustomerRepository customerRepository = _UnitOfWork.CustomerRepository;
                try
                {
                    //--------
                    DGV1.DataSource = customerRepository.GetCustomerList();
                    DGV1.Columns["NationalCode"].HeaderText = " کد ملی";
                    DGV1.Columns["Name"].HeaderText = " نام";
                    DGV1.Columns["Phone"].HeaderText = " تلفن";
                    DGV1.Columns["State"].HeaderText = " استان";
                    DGV1.Columns["ZipCode"].HeaderText = " کد پستی";
                    DGV1.Columns["Email"].HeaderText = " ایمیل";
                    DGV1.Columns["City"].HeaderText = " شهر";
                    DGV1.Columns["Address"].HeaderText = " آدرس";


                    //----------------------------------


                }
                catch
                {
                    MessageBox.Show(" خطایی رخ داده است");
                }
            }
        }

            private void btnExport_Click(object sender, EventArgs e)
        {
            WorkWithExcel.ExportExcel(DGV1);
        }

        private void frmCustomerRecords_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txtNationalCode_TextChanged(object sender, EventArgs e)
        {
            if (txtNationalCode.Text == "")
            {
                LoadData();
            }
            else
            {
                using (UnitOfWork _UnitOfWork = new UnitOfWork())
                {
                    ICustomerRepository _customerRepository = _UnitOfWork.CustomerRepository;
                    try
                    {
                        DGV1.DataSource = _customerRepository.GetCustomerListByNationalCodeFilter(long.Parse(txtNationalCode.Text));

                    }
                    catch
                    {
                        MessageBox.Show(" خطایی رخ داده است");
                    }

                }
            }
        }

        private void DGV1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow dr = DGV1.SelectedRows[0];
                this.Hide();
                frmCustomer obj = new frmCustomer();

                obj.Show();
                obj.txtNationalCode.Text = dr.Cells["NationalCode"].Value.ToString();
                obj.txtCustomerName.Text = dr.Cells["Name"].Value.ToString();
                obj.txtCustomerPhone.Text = dr.Cells["Phone"].Value.ToString();
                obj.txtCustomerState.Text = dr.Cells["State"].Value.ToString();
                obj.txtCustomerEmail.Text = dr.Cells["Email"].Value.ToString();
                obj.txtCustomerCity.Text = dr.Cells["City"].Value.ToString();
                obj.txtCustomerZipCode.Text = dr.Cells["ZipCode"].Value.ToString();
                obj.txtCustomerAddress.Text = dr.Cells["Address"].Value.ToString();
                obj.txtCustomerName.Focus();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





































        //---End Block of Class And Namespace------------------------
    }
}
