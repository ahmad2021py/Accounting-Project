using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces;
using Accounting.DataLayer.Services;
using Accounting.Utilities;
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
    public partial class frmStock : Form
    {
        public frmStock()
        {
            InitializeComponent();
        }


        private void Reset()
        {
            //--textboxes
            txtBuyPrice.Text = "";
            txtDescription.Text = "";
            txtProductId.Text = "";
            txtProductQuantity.Text = "";
            txtTotalPrice.Text = "";
            bPersianCalenderTextBox1.Text = "";
            txtProductId.Focus();
            ///----labels--------
            lblBuyPrice.Text = "";
            lblCategory.Text = "";
            lblCompany.Text = "";
            lblCount.Text = "";
            lblDescription.Text = "";
            lblFeatures.Text = "";
            lblGetDateTime.Text = "";
            lblPrice.Text = "";
            lblProductName.Text = "";
            lblSellPrice.Text = "";
            lblTotalPrice.Text = "";


        }

        private bool IsNull()
        {
            if (txtBuyPrice.Text == "" ||
                txtDescription.Text == "" ||
               txtProductId.Text == "" ||
               txtProductQuantity.Text == "" ||
               txtTotalPrice.Text == "" ||
               bPersianCalenderTextBox1.Text == "")

                return true;
            else
            {
                return false;
            }

        }

        private Stock Fill__StockRecord(Stock stockRecord)
        {




            stockRecord.FKProductId =int.Parse(txtProductId.Text) ;
            stockRecord.Quantity = Convert.ToInt32(txtProductQuantity.Text);
              stockRecord.StockDate =DateTime.Parse(bPersianCalenderTextBox1.Text) ;
            stockRecord.StockDate = DateTime.Now;
            stockRecord.TotalPrice =Int32.Parse(txtTotalPrice.Text) ;
            stockRecord.Description = txtDescription.Text;
         
            return stockRecord;



        }
        private void btnShowFrmProduct_Click(object sender, EventArgs e)
        {
            frmProduct frm = new frmProduct();
            frm.txtProductCode.Text =txtProductId.Text;
            
            frm.ShowDialog();

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            frmProductRecords frm = new frmProductRecords(this);
            frm.Show();
            this.Hide();


        }

        private void btnShowFrmStockRecords_Click(object sender, EventArgs e)
        {
            frmStockRecords frm = new frmStockRecords();
            frm.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            //try
            //{

                using (UnitOfWork _UnitOfWork = new UnitOfWork())
                {
                    IStockRepository _StockRepository = _UnitOfWork.StockRepository;
                    if (!IsNull())
                    {

                        int productId = Int32.Parse(txtProductId.Text);
                        IProductRepository _ProductRepository = _UnitOfWork.ProductRepository;

                        bool StockResult =  _StockRepository.IsExist<Stock>(n => n.FKProductId == productId);
                        bool ProductResult = _ProductRepository.IsExist<Product>(n => n.id == productId);
                    if (!ProductResult)
                    {
                        MessageBox.Show("محصولی با این کد وجود ندارد");
                        return;
                    }
                        if (!StockResult)
                        {

                            Stock StockRecord = new Stock();
                             StockRecord = Fill__StockRecord(StockRecord);
                            
                        
                            if (_StockRepository.Add<Stock>(StockRecord))
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
            //}
            //catch
            //{
            //    MessageBox.Show("خطایی رخ داده است");
            //}
        }
    }
}
