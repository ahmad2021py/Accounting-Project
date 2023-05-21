using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces;
using Accounting.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting.GUI.Forms
{
    public partial class frmConfig : Form
    {
        //------------Fields----------------



        //------------Methods----------------
        public frmConfig()
        {
            InitializeComponent();
        }
        private void Reset()
        {
            txtPrice.Text = "";
            txtFeatures.Text = "";
            cmbProductName.Text = "";
            //btnDelete.Enabled = false;
            //btnUpdate.Enabled = false;
            //btnSave.Enabled = true;
            PboxProductPicture.Image = null;
            PboxProductPicture.Image = Properties.Resources.icons8_product_128px_2;
            cmbProductName.Focus();
        }

        private bool IsNull()
        {
            if (txtPrice.Text == "" ||
                txtFeatures.Text == "" ||
                cmbProductName.Text == "")
                return true;
            else
            {
                return false;
            }

        }

        private Config Fill__ConfigRecord(Config configRecord)
        {
            //configRecord.ConfigId = Convert.ToInt32(lblproductId.Text);
            configRecord.ProductName = cmbProductName.Text;
            configRecord.Price = Convert.ToDouble(txtPrice.Text);
            configRecord.Features = txtFeatures.Text;
            configRecord.Picture = WorkWithImage.imageToByteArray(PboxProductPicture.Image);
            return configRecord;

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            Reset();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            using (UnitOfWork _UnitOfWork = new UnitOfWork())
            {
                IConfigRepository _ConfigRepository = _UnitOfWork.ConfigRepository;
                if (!IsNull())
                {
                    bool Result = await _ConfigRepository.ConfigExist(cmbProductName.Text);
                    if (!Result)
                    {
                        //using (UnitOfWork _unitOfWork = new UnitOfWork())
                        //{
                        Config configRecord = new Config();
                        configRecord = Fill__ConfigRecord(configRecord);

                        if (_ConfigRepository.InsertToConfig(configRecord))
                        {
                            MessageBox.Show("رکورد با موفقیت ثبت شد");

                            _UnitOfWork.Save();
                            Reset();
                        }
                        else
                        {
                            MessageBox.Show("خطایی رخ داده است");
                        }
                    }
                    else
                    {
                        MessageBox.Show("این محصول از قبل وجود دارد");
                        Reset();
                    }
                }
                else
                {
                    MessageBox.Show("لطفا فیلد های خواسته شده را پر کنید");

                }
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {

            {
                try
                {
                    OpenFileDialog OFD = new OpenFileDialog();

                    OFD.Filter = ("Image Files |*.png; *.bmp; *.jpg;*.jpeg; *.gif;");
                    OFD.FilterIndex = 4;
                    //Reset the file name
                    OFD.FileName = "";

                    if (OFD.ShowDialog() == DialogResult.OK)
                    {
                        PboxProductPicture.Image = Image.FromFile(OFD.FileName);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا از حذف رکورد اطمینان دارید ؟", "تایید کردن", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                using (UnitOfWork _unitOfWork = new UnitOfWork())
                {
                    IConfigRepository _ConfigRepository = _unitOfWork.ConfigRepository;

                    bool result = await _ConfigRepository.ConfigExist(cmbProductName.Text);
                    if (result)
                    {
                        if (_ConfigRepository.DeleteConfigRecord(cmbProductName.Text))
                            MessageBox.Show("رکورد با موفقیت حذف شد");
                           _unitOfWork.Save();
                            Reset();


                    }
                    else
                    {
                        MessageBox.Show("خطایی رخ داده است");
                    }






                }

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (UnitOfWork _unitOfWork = new UnitOfWork())
            {
                IConfigRepository ConfigRepository = _unitOfWork.ConfigRepository;
                Config Instance = new Config();
                Instance = Fill__ConfigRecord(Instance);
                if (ConfigRepository.UpdateRecord(Instance))
                {
                    MessageBox.Show("رکورد با موفقیت  بروز شد");
                    _unitOfWork.Save();
                    Reset();
                }
                else
                {
                    MessageBox.Show("خطایی رخ داده است");
                }

            }
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            frmConfigRecords frm = new frmConfigRecords();
            frm.ShowDialog();
            this.Hide();
        }



















        //---End Block of Class And Namespace------------------------

    }
}
