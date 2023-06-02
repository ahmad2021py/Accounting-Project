using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces.IRepositories;
using System;
using System.Windows.Forms;

namespace Accounting.GUI.Forms
{
    public partial class frmCompany : Form
    {
        public frmCompany()
        {
            InitializeComponent();
        }

        void Reset()
        {
            txtCompanyName.Text = "";
            // btnSave.Enabled = true;
            // btnDelete.Enabled = false;
            txtCompanyName.Focus();

        }


        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCompanyName.Text) || string.IsNullOrWhiteSpace(txtCompanyName.Text))
            {

                MessageBox.Show("ورودی نامعتبر");
                return;
            }
            if (MessageBox.Show("آیا از حذف رکورد اطمینان دارید ؟", "تایید کردن", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            using (UnitOfWork _unitOfWork = new UnitOfWork())
            {
                ICompanyRepository _CompanyRepository = _unitOfWork.CompanyRepository;

                bool Result = await _CompanyRepository.IsExist<Company>(n => n.CompanyName == txtCompanyName.Text);
                if (!Result)
                {
                    MessageBox.Show("شرکتی با این نام موجود نیست");
                    return;

                }

                bool result = await _CompanyRepository.DeleteByCondition<Company>(n => n.CompanyName == txtCompanyName.Text);

                if (!result)
                {

                    MessageBox.Show("در عملیات حذف خطایی رخ داده است");
                    return;
                }

                _unitOfWork.Save();

            }

            MessageBox.Show("رکورد با موفقیت حذف شد");

            Reset();




        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Reset();
        }



        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCompanyName.Text) || string.IsNullOrWhiteSpace(txtCompanyName.Text))
            {

                MessageBox.Show("ورودی نامعتبر");
                return;
            }


            using (UnitOfWork _UnitOfWork = new UnitOfWork())
            {
                ICompanyRepository _CompanyRepository = _UnitOfWork.CompanyRepository;
                bool result = await _CompanyRepository.IsExist<Company>(n => n.CompanyName == txtCompanyName.Text);
                if (result)
                {
                    MessageBox.Show("این شرکت از قبل وجود دارد");
                    return;
                }

                Company Record = new Company();
                Record.CompanyName = txtCompanyName.Text;
                bool AddResult = await _CompanyRepository.Add<Company>(Record);
                if (AddResult)
                {
                    MessageBox.Show("شرکت با موفقیت اضافه شد");
                    txtCompanyName.Text = "";
                    _UnitOfWork.Save();

                }

            }


        }




        private void frmCompany_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnShowfrmCompanyRecords_Click(object sender, EventArgs e)
        {
            frmCompanyRecords frmCompanyRecords = new frmCompanyRecords();
            if (frmCompanyRecords.ShowDialog() == DialogResult.OK)
            {

                frmCompanyRecords.Close();
                txtCompanyName.Text = frmCompanyRecords._CompanyName;
                frmCompanyRecords = null;

            }
        }
    }
}

