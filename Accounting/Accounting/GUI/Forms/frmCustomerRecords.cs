using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces;
using Accounting.Utilities;
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

        public string _Address;
        public string _ZipCode;
        public string _City;
        public string _Email;
        public string _State;
        public string _Phone;
        public string _Name;
        public string _NationalCode;


        async void LoadData()
        {
            using (UnitOfWork _UnitOfWork = new UnitOfWork())
            {
                ICustomerRepository customerRepository = _UnitOfWork.CustomerRepository;
                //--------
                IEnumerable<Customer> IEnamrableCustomerDbRecords = await customerRepository.GetAll<Customer>(n => n == n);
                DGV1.DataSource = IEnamrableCustomerDbRecords;
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
        }

     

        private void frmCustomerRecords_Load(object sender, EventArgs e)
        {
            LoadData();
        }



      

     




        private void frmCustomerRecords_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

     async   private void txtNationalCode_TextChanged(object sender, EventArgs e)
        {
            if (txtNationalCode.Text == "")
            {
                LoadData();
                return;
            }


            using (UnitOfWork _UnitOfWork = new UnitOfWork())
            {
                ICustomerRepository _CustomerRepository = _UnitOfWork.CustomerRepository;


                IEnumerable<Customer> IEnamrableCustomerDbRecords = await _CustomerRepository.GetAll<Customer>(n => n.NationalCode.ToString().Contains(txtNationalCode.Text));
                DGV1.DataSource = IEnamrableCustomerDbRecords;



            }





        }

        async private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {
            if (txtCustomerName.Text == "")
            {
                LoadData();
                return;
            }



            using (UnitOfWork _UnitOfWork = new UnitOfWork())
            {
                ICustomerRepository _CustomerRepository = _UnitOfWork.CustomerRepository;


                IEnumerable<Customer> IEnamrableCustomerDbRecords = await _CustomerRepository.GetAll<Customer>(n => n.Name.Contains(txtCustomerName.Text));
                DGV1.DataSource = IEnamrableCustomerDbRecords;



            }

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            ////Load File
            // stiReport1.Load(Application.StartupPath + "/Reports/Customer.mrt");
            // stiReport1.Compile();
            // //Set Variables
            // stiReport1["Name"] = "ahmad";
            // stiReport1["Email"] = "gmail.com";
            // stiReport1["Address"] = "شوشتر";
            // stiReport1["id"] = 4; 
            // stiReport1["NationalCode"] = 5558818125;
            // stiReport1["ZipCode"] = "u";
            // //Show
            // stiReport1.Show();
        }

       
      

        private void btnExport_Click_1(object sender, EventArgs e)
        {

        }

        private void btnExcelExport_Click(object sender, EventArgs e)
        {
            WorkWithExcel.ExportExcel(DGV1);
        }

        private void DGV1_CellDoubleClick_(object sender, DataGridViewCellEventArgs e)
        {

            _NationalCode = DGV1.Rows[e.RowIndex].Cells["NationalCode"].Value.ToString();
            _Name = DGV1.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            _Phone = DGV1.Rows[e.RowIndex].Cells["Phone"].Value.ToString();
            _State = DGV1.Rows[e.RowIndex].Cells["State"].Value.ToString();
            _Email = DGV1.Rows[e.RowIndex].Cells["Email"].Value.ToString();
            _City = DGV1.Rows[e.RowIndex].Cells["City"].Value.ToString();
            _ZipCode = DGV1.Rows[e.RowIndex].Cells["ZipCode"].Value.ToString();
            _Address = DGV1.Rows[e.RowIndex].Cells["Address"].Value.ToString();
            this.DialogResult = DialogResult.OK;
        }





































        //---End Block of Class And Namespace------------------------
    }
}
