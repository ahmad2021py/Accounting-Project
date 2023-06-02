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
           
            txtDescription.Text = "";
            txtProductCode.Text = "";
            txtProductQuantity.Text = "";

            bPersianCalenderTextBox1.Text = "";
            txtProductCode.Focus();
           



        }

        private bool IsNull()
        {
            if (
            
                 string.IsNullOrEmpty(txtDescription.Text) ||
                 string.IsNullOrEmpty(txtProductCode.Text) ||
                 string.IsNullOrEmpty(txtProductQuantity.Text) ||
                 string.IsNullOrEmpty(txtStockCode.Text) ||
                 string.IsNullOrEmpty(bPersianCalenderTextBox1.Text) ||
           
                 string.IsNullOrWhiteSpace(txtDescription.Text) ||
                 string.IsNullOrWhiteSpace(txtProductCode.Text) ||
                 string.IsNullOrWhiteSpace(txtProductQuantity.Text) ||
                 string.IsNullOrWhiteSpace(txtStockCode.Text)
                 )





                return true;
            else
            {
                return false;
            }

        }

        private Stock Fill__StockRecord(Stock stockRecord)
        {



            string ShamsiDate = bPersianCalenderTextBox1.Text;
            WorkWithDate workWithDate = new WorkWithDate();
            stockRecord.StockCode = Convert.ToInt32(txtStockCode.Text);

            stockRecord.StockDate = workWithDate.ShamsiToMiladi(ShamsiDate);
            stockRecord.FKProduct = int.Parse(txtProductCode.Text);
            stockRecord.Quantity = Convert.ToInt32(txtProductQuantity.Text);

   
            stockRecord.Description = txtDescription.Text;

            return stockRecord;



        }

        private StockEntityWithoutRowPropertyForUpdate Fill__StockRecord(StockEntityWithoutRowPropertyForUpdate stockRecord)
        {



            string ShamsiDate = bPersianCalenderTextBox1.Text;
            WorkWithDate workWithDate = new WorkWithDate();
            stockRecord.StockCode = Convert.ToInt32(txtStockCode.Text);

            stockRecord.StockDate = workWithDate.ShamsiToMiladi(ShamsiDate);
            stockRecord.FKProduct = int.Parse(txtProductCode.Text);
            stockRecord.Quantity = Convert.ToInt32(txtProductQuantity.Text);

      
            stockRecord.Description = txtDescription.Text;

            return stockRecord;



        }
      




        private void btnShowFrmProduct_Click(object sender, EventArgs e)
        {
            frmProduct frm = new frmProduct();
            frm.txtProductCode.Text = txtProductCode.Text;

            frm.ShowDialog();

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            frmProductRecords formProductRecords = new frmProductRecords(this);
            if (formProductRecords.ShowDialog() == DialogResult.OK)
            {

                formProductRecords.Close();
                this.txtProductCode.Text = formProductRecords._ProductCode;
           
                formProductRecords = null;



            }



        }

        private void btnShowFrmStockRecords_Click(object sender, EventArgs e)
        {
            frmStockRecords frmStockRecords = new frmStockRecords();
            if (frmStockRecords.ShowDialog() == DialogResult.OK)
            {

                frmStockRecords.Close();
                this.txtStockCode.Text = frmStockRecords._StockCode;
                this.txtProductCode.Text = frmStockRecords._FKProductId;
                this.txtDescription.Text = frmStockRecords._Description;
                this.txtProductQuantity.Text = frmStockRecords._Quantity;
                this.bPersianCalenderTextBox1.Text = frmStockRecords._StockDate;
                frmStockRecords = null;


            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            



            bool IntVlaidationResult = WorkWithStrings.TextToIntVlaidation(txtProductCode.Text);
            bool IntVlaidationResult2 = WorkWithStrings.TextToIntVlaidation(txtProductQuantity.Text);
 

            if (!IntVlaidationResult || !IntVlaidationResult2 )
            {
                // MessageBox.Show("فیلد کد باید عددی صحیح باشد ");
                txtProductCode.Text = "";
                return;
            }



            using (UnitOfWork _UnitOfWork = new UnitOfWork())
            {
                IStockRepository _StockRepository = _UnitOfWork.StockRepository;
                if (IsNull())
                {


                    MessageBox.Show("لطفا فیلد های خواسته شده را پر کنید");
                    return;


                }
                int StockCode = Int32.Parse(txtStockCode.Text);
                int ProductCode = Int32.Parse(txtProductCode.Text);
                IProductRepository _ProductRepository = _UnitOfWork.ProductRepository;

                bool StockResult = await _StockRepository.IsExist<Stock>(n => n.StockCode == StockCode);
                bool ProductResult = await _ProductRepository.IsExist<Product>(n => n.ProductCode == ProductCode);

                if (!ProductResult)
                {
                    MessageBox.Show("محصولی با این کد وجود ندارد");
                    return;
                }
                if (StockResult)
                {

                    MessageBox.Show("این کد انبار از قبل وجود دارد ");
                    Reset();
                    return;
                }

                Stock StockRecord = new Stock();
                StockRecord = Fill__StockRecord(StockRecord);
                bool AddResult = await _StockRepository.Add<Stock>(StockRecord);

                if (AddResult)
                {
                    MessageBox.Show("رکورد با موفقیت ثبت شد");

                    _UnitOfWork.Save();
                    Reset();
                }
                else
                {
                    MessageBox.Show("خطایی در افزودن رکورد رخ داده است");
                }


            }

        }

      

        async private void btnUpdate_Click(object sender, EventArgs e)
        {


            if (IsNull())
            {



                MessageBox.Show("لطفا فیلد های خواسته شده را پر کنید");

                return;



            }

            
                using (UnitOfWork _unitOfWork = new UnitOfWork())
            {

                IStockRepository _StockRepository = _unitOfWork.StockRepository;

                StockEntityWithoutRowPropertyForUpdate Instance = new StockEntityWithoutRowPropertyForUpdate();
                Instance = Fill__StockRecord(Instance);
                int stockCode = int.Parse(txtStockCode.Text);
                bool UpdateProductResult = await _StockRepository.UpdateStock(Instance, n => n.StockCode == stockCode);
                if (UpdateProductResult)
                {

                    MessageBox.Show("رکورد با موفقیت  بروز شد");

                    _unitOfWork.Save();

                    Reset();
                }
                else
                {

                    MessageBox.Show("خطایی رخ داده است");

                    return;
                }

            }


        }

        private void txtProductId_TextChanged(object sender, EventArgs e)
        {
            bool IntVlaidationResult = WorkWithStrings.TextToIntVlaidation(txtProductCode.Text);


            if (!IntVlaidationResult)
            {
                // MessageBox.Show("فیلد کد باید عددی صحیح باشد ");
                txtProductCode.Text = "";
                return;
            }

        }

        private void txtProductQuantity_TextChanged(object sender, EventArgs e)
        {

            bool IntVlaidationResult = WorkWithStrings.TextToIntVlaidation(txtProductQuantity.Text);


            if (!IntVlaidationResult)
            {
                // MessageBox.Show("فیلد کد باید عددی صحیح باشد ");
                txtProductCode.Text = "";
                return;
            }

        }

    


        private void frmStock_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Reset();
        }

        async private void btnDelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("آیا از حذف رکورد اطمینان دارید ؟", "تایید کردن", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {

                using (UnitOfWork _unitOfWork = new UnitOfWork())
                {


                    IStockRepository _StockRepository = _unitOfWork.StockRepository;


                    int StockCode = Convert.ToInt32(txtStockCode.Text);

                    bool result = await _StockRepository.IsExist<Stock>(N => N.StockCode == StockCode);
                    if (result)
                    {

                        bool DeleteResult = await _StockRepository.DeleteByCondition<Stock>(n => n.StockCode == StockCode);

                        if (DeleteResult)
                            MessageBox.Show("رکورد با موفقیت حذف شد");

                        _unitOfWork.Save();

                        Reset();


                    }
                    else
                    {

                        MessageBox.Show("خطایی رخ داده است");

                        return;
                    }






                }

            }

        }

        private void frmStock_Load(object sender, EventArgs e)
        {
            Reset();
        }

        private void txtProductQuantity_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
