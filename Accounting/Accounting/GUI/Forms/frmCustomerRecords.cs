using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces;
using AccountingDLL;
using Stimulsoft.Report;
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
        //-----Fields-------------------
        #region class Fields
        private StiReport stiReport1;

        
        #endregion
        //------Methods------------
        public frmCustomerRecords()
        {
            InitializeComponent();
            stiReport1 = new StiReport();
            // How to Activate Stimulsoft
            Stimulsoft.Base.StiLicense.Key = "6vJhGtLLLz2GNviWmUTrhSqnOItdDwjBylQzQcAOiHn0s4gy0Fr5YoUZ9V00Y0igCSFQzwEqYBh/N77k4f0fWXTHW5rqeBNLkaurJDenJ9o97TyqHs9HfvINK18Uwzsc/bG01Rq+x3H3Rf+g7AY92gvWmp7VA2Uxa30Q97f61siWz2dE5kdBVcCnSFzC6awE74JzDcJMj8OuxplqB1CYcpoPcOjKy1PiATlC3UsBaLEXsok1xxtRMQ283r282tkh8XQitsxtTczAJBxijuJNfziYhci2jResWXK51ygOOEbVAxmpflujkJ8oEVHkOA/CjX6bGx05pNZ6oSIu9H8deF94MyqIwcdeirCe60GbIQByQtLimfxbIZnO35X3fs/94av0ODfELqrQEpLrpU6FNeHttvlMc5UVrT4K+8lPbqR8Hq0PFWmFrbVIYSi7tAVFMMe2D1C59NWyLu3AkrD3No7YhLVh7LV0Tttr/8FrcZ8xirBPcMZCIGrRIesrHxOsZH2V8t/t0GXCnLLAWX+TNvdNXkB8cF2y9ZXf1enI064yE5dwMs2fQ0yOUG/xornE";
            //Stimulsoft.Base.StiLicense.LoadFromFile("license.key");
        }

        void LoadData()
        {
            using (UnitOfWork _UnitOfWork = new UnitOfWork())
            {
                ICustomerRepository customerRepository = _UnitOfWork.CustomerRepository;
                try
                {
                    //--------
                    DGV1.DataSource = customerRepository.GetAll<Customer>(n=>n==n);
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
                        long nationalCode= long.Parse(txtNationalCode.Text);
                        DGV1.DataSource = _customerRepository.GetAll<Customer>(n=>n.NationalCode== nationalCode);

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
                obj.cbStates.Text = dr.Cells["State"].Value.ToString();
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

        private void btnReport_Click(object sender, EventArgs e)
        {
           //Load File
            stiReport1.Load(Application.StartupPath + "/Reports/Customer.mrt");
            stiReport1.Compile();
            //Set Variables
            stiReport1["Name"] = "ahmad";
            stiReport1["Email"] = "gmail.com";
            stiReport1["Address"] = "شوشتر";
            stiReport1["id"] = 4; 
            stiReport1["NationalCode"] = 5558818125;
            stiReport1["ZipCode"] = "u";
            //Show
            stiReport1.Show();
        }





































        //---End Block of Class And Namespace------------------------
    }
}
