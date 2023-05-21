using Accounting.DataLayer.Context;
using Accounting.DataLayer.Interfaces;
using AccountingDLL;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Accounting.GUI.Forms
{
    public partial class frmConfigRecords : Form
    {
        //------------Fields----------------

        //-------Methods--------------------------
        public frmConfigRecords()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            using (UnitOfWork _UnitOfWork = new UnitOfWork())
            {
                IConfigRepository configRepository = _UnitOfWork.ConfigRepository;
                try
                {
                    //--------
                    DGV1.DataSource = configRepository.GetConfigList();
                    DGV1.Columns[0].HeaderText = " کد محصول";
                    DGV1.Columns[1].HeaderText = " نام محصول";
                    DGV1.Columns[2].HeaderText = " ویژگی";
                    DGV1.Columns[3].HeaderText = " قیمت";
                    DGV1.Columns[4].Visible = false;//Picture Column
                    //----------------------------------


                }
                catch
                {
                    MessageBox.Show(" خطایی رخ داده است");
                }
            }
        }
        
        private void frmConfigRecords_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {
            if (txtProductName.Text == "")
            {
                LoadData();
            }
            else
            {
                using (UnitOfWork _UnitOfWork = new UnitOfWork())
                {
                    IConfigRepository _configRepository = _UnitOfWork.ConfigRepository;
                    try
                    {
                        DGV1.DataSource = _configRepository.GetConfigListByProductNameFilter(txtProductName.Text);

                    }
                    catch
                    {
                        MessageBox.Show(" خطایی رخ داده است");
                    }

                }
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            WorkWithExcel.ExportExcel(DGV1);
        }

        private void DGV1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow dr = DGV1.SelectedRows[0];
                this.Hide();
                frmConfig obj = new frmConfig();

                obj.Show();
                obj.cmbProductName.Text = dr.Cells[1].Value.ToString();
                obj.txtFeatures.Text = dr.Cells[2].Value.ToString();
                obj.txtPrice.Text = dr.Cells[3].Value.ToString();
                byte[] data = (byte[])dr.Cells[4].Value;
                MemoryStream ms = new MemoryStream(data);
                obj.PboxProductPicture.Image = Image.FromStream(ms);
                obj.cmbProductName.Focus();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }























        //---End Block of Class And Namespace------------------------
    }
}
