using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces;
using Accounting.DataLayer.Services;
using Accounting.Utilities;
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
            if (MessageBox.Show("آیا از حذف رکورد اطمینان دارید ؟", "تایید کردن", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                using (UnitOfWork _unitOfWork = new UnitOfWork())
                {
                    ICompanyRepository _CompanyRepository = _unitOfWork.CompanyRepository;


                    if (_CompanyRepository.IsExist<Company>(n => n.CompanyName == txtCompanyName.Text))
                    {
                        bool result = await _CompanyRepository.DeleteByCondition<Company>(n => n.CompanyName == txtCompanyName.Text);
                        if (result)
                        {

                            MessageBox.Show("رکورد با موفقیت حذف شد");
                            _unitOfWork.Save();
                            Reset();
                        }

                    }
                    else
                    {
                        MessageBox.Show("خطایی رخ داده است");
                    }






                }

            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Reset();
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            if (WorkWithTextboxes.TextBoxisNull(txtCompanyName.Text))
            {

                MessageBox.Show("لطفا نام شرکت را مشخص کنید");

            }
            else
            {

                using (UnitOfWork _UnitOfWork = new UnitOfWork())
                {
                    ICompanyRepository _CompanyRepository = _UnitOfWork.CompanyRepository;
                    if (_CompanyRepository.IsExist<Company> (n => n.CompanyName == txtCompanyName.Text))
                    {
                        MessageBox.Show("این شرکت از قبل وجود دارد");
                    }
                    else
                    {
                        Company Record = new Company();
                        Record.CompanyName = txtCompanyName.Text;
                        if (_CompanyRepository.Add<Company>(Record))
                        {
                            MessageBox.Show("شرکت با موفقیت اضافه شد");
                            txtCompanyName.Text = "";
                            _UnitOfWork.Save();

                        }

                    }
                }
            }
        }

        private void frmCompany_Load(object sender, EventArgs e)
        {

        }

        private void btnGetData_Click(object sender, EventArgs e)
        {

            frmCompanyRecords frm = new frmCompanyRecords();
            frm.ShowDialog();
               
            
        }

        private void frmCompany_FormClosed(object sender, FormClosedEventArgs e)
        {
            WorkWithGlobalForms.frmMainMenu.Show();
            this.Hide();
        }
    }
}

