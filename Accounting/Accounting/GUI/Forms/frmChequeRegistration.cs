using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces.IRepositories;
using Accounting.Utilities;
using System;
using System.Windows.Forms;

namespace Accounting.GUI.Forms
{
    public partial class frmChequeRegistration : Form
    {
        public frmChequeRegistration()
        {
            InitializeComponent();
        }

        private void Reset()
        {
            txtAmount.Text = "";
            txtBankBranch.Text = "";
            txtChequeBank.Text = "";
            txtChequeCode.Text = "";
            bPersianCalenderTextBox1.Text = "";
            cbStatus.Text = "";

        }

        async private void btnSave_Click(object sender, EventArgs e)
        {

            if (WorkWithStrings.StringIsNullOrEmptyOrWhiteSpace(txtAmount.Text, txtBankBranch.Text, txtChequeBank.Text, txtChequeCode.Text))
            {

                MessageBox.Show("ورودی نامعتبر");
                return;
            }

            using (UnitOfWork _UnitOfWork = new UnitOfWork())
            {
                IChequeRepository chequeRepository = _UnitOfWork.ChequeRepository;
                bool result = await chequeRepository.IsExist<Cheque>(n => n.ChequeCode == txtChequeCode.Text);
                if (result)
                {
                    MessageBox.Show("این چک از قبل وجود دارد");
                    return;
                }

                Cheque Record = new Cheque();
                Record.ChequeCode = txtChequeCode.Text;
                Record.Amount = decimal.Parse(txtChequeCode.Text);
                Record.Bank = txtChequeBank.Text;
                Record.BankBranch = txtBankBranch.Text;
                WorkWithDate workWithDate = new WorkWithDate();
                Record.ChequeDate = workWithDate.ShamsiToMiladi(bPersianCalenderTextBox1.Text);
                Record.Status = cbStatus.Text;
                bool AddRresult = await chequeRepository.Add<Cheque>(Record);
                if (!AddRresult)
                {
                    MessageBox.Show("در افزودن مورد خطایی رخ داده");
                    return;

                }


                try
                {
                    _UnitOfWork.Save();
                }

                catch
                {
                    MessageBox.Show("در ذخیره تغییرات خطایی رخ داده است");
                    return;
                }

                MessageBox.Show(" چک با موفقیت ثبت شد");
                Reset();





            }
        }

        async private void btnDelete_Click(object sender, EventArgs e)
        {
            if (WorkWithStrings.StringIsNullOrEmptyOrWhiteSpace(txtChequeCode.Text))
            {

                MessageBox.Show("ورودی نامعتبر");
                return;
            }


            if (MessageBox.Show("آیا از حذف رکورد اطمینان دارید ؟", "تایید کردن", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (UnitOfWork _unitOfWork = new UnitOfWork())
                {
                    IChequeRepository chequeRepository = _unitOfWork.ChequeRepository;

                    bool Result = await chequeRepository.IsExist<Cheque>(n => n.ChequeCode == txtChequeCode.Text);
                    if (!Result)
                    {
                        MessageBox.Show("چک با این نام وجود ندارد");
                        Reset();
                        return;
                    }
                    bool result = await chequeRepository.DeleteByCondition<Cheque>(n => n.ChequeCode == txtChequeCode.Text);
                    if (!result)
                    {
                        MessageBox.Show("خطایی هنگام حذف مورد رخ داده است");
                        return;

                    }


                    try
                    {
                        _unitOfWork.Save();
                        MessageBox.Show("رکورد با موفقیت حذف شد");
                    }


                    catch
                    {
                        MessageBox.Show("خطایی هنگام حذف مورد رخ داده است");
                    }


                    Reset();


                }

            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnShowfrmChequeRecords_Click(object sender, EventArgs e)
        {

            frmChequeRecords frmChequeRecords = new frmChequeRecords();
            if (frmChequeRecords.ShowDialog() == DialogResult.OK)
            {

                frmChequeRecords.Close();

                frmChequeRecords = null;

            }
        }
    }
}
