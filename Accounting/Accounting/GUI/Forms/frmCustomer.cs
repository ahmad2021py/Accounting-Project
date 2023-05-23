﻿using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces;
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
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }

        private bool IsNull()
        {
            if (
                txtCustomerName.Text == "" ||
                txtCustomerPhone.Text == "" ||
                txtCustomerState.Text == "" ||
                txtCustomerAddress.Text == "" ||
                txtCustomerZipCode.Text == "" ||
                txtCustomerCity.Text == ""
                )

                return true;
            else
            {
                return false;
            }

        }

        private void Reset()
        {
            txtNationalCode.Text = "";
            txtCustomerName.Text = "";
            txtCustomerPhone.Text = "";
            txtCustomerEmail.Text = "";
            txtCustomerState.Text = "";
            txtCustomerCity.Text = "";
            txtCustomerZipCode.Text = "";
            txtCustomerAddress.Text = "";
            txtCustomerName.Focus();
        }




        private Customer Fill__CustomerRecord(Customer CustomerRecord)
        {
            CustomerRecord.NationalCode = long.Parse(txtNationalCode.Text);
            CustomerRecord.Name = txtCustomerName.Text;
            CustomerRecord.Phone = txtCustomerPhone.Text;
            CustomerRecord.State = txtCustomerState.Text;
            CustomerRecord.ZipCode = txtCustomerZipCode.Text;
            CustomerRecord.Email = txtCustomerEmail.Text;
            CustomerRecord.City = txtCustomerCity.Text;
            CustomerRecord.Address = txtCustomerAddress.Text;
            return CustomerRecord;

        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            frmCustomerRecords frm = new frmCustomerRecords();
            frm.ShowDialog();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try {
                using (UnitOfWork _unitOfWork = new UnitOfWork())
                {
                    ICustomerRepository _customerRepository = _unitOfWork.CustomerRepository;
                    Customer Instance = new Customer();
                    Instance = Fill__CustomerRecord(Instance);
                    if (_customerRepository.UpdateRecord(Instance))
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

            catch
            {
                MessageBox.Show("خطایی رخ داده است");
            }
            }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            using (UnitOfWork _UnitOfWork = new UnitOfWork())
            {
                ICustomerRepository _CustomerRepository = _UnitOfWork.CustomerRepository;
                if (!IsNull())
                {
                    string nationalCode = NationalCode.NationalCodeValidation(txtNationalCode.Text);
                    if (nationalCode == "NotValid")
                    {
                        MessageBox.Show("کد ملی نامعتبر است");
                        return;
                    }

                    bool Result = await _CustomerRepository.CustomerExist(long.Parse(nationalCode));
                    if (!Result)
                    {
                        using (UnitOfWork _unitOfWork = new UnitOfWork())
                        {
                            Customer CustomerRecord = new Customer();
                            CustomerRecord = Fill__CustomerRecord(CustomerRecord);

                            if (_CustomerRepository.InsertToCustomer(CustomerRecord))
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
                    }
                    else
                    {
                        MessageBox.Show("این مشتری از قبل وجود دارد");
                        Reset();
                    }
                }
                else
                {
                    MessageBox.Show("لطفا فیلد های خواسته شده را پر کنید");

                }
            }
        }

        private void btnSave_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtNationalCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            // این چهار خط کد برای مجور کردن کاربر به وارد کردن فقط عدد است 
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
                e.Handled = true;
            else if (txtNationalCode.Text.Length == 10 && e.KeyChar != (char)Keys.Back && txtNationalCode.SelectedText.Length == 0)
                e.Handled = true;
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("آیا از حذف رکورد اطمینان دارید ؟", "تایید کردن", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    string nationalCode = NationalCode.NationalCodeValidation(txtNationalCode.Text);
                    if (nationalCode == "NotValid")
                    {
                        MessageBox.Show("کد ملی نامعتبر است");
                        return;
                    }

                    using (UnitOfWork _unitOfWork = new UnitOfWork())
                    {

                        ICustomerRepository _CustomerRepository = _unitOfWork.CustomerRepository;

                        bool Result = await _CustomerRepository.CustomerExist(long.Parse(txtNationalCode.Text));
                        if (Result)
                        {
                            if (_CustomerRepository.DeleteCustomerRecord(long.Parse(txtNationalCode.Text)))
                            {
                                MessageBox.Show("رکورد با موفقیت حذف شد");
                                _unitOfWork.Save();
                                Reset();
                               
                            }


                        }
                        else
                        {
                            MessageBox.Show("خطایی رخ داده است");
                            return;
                        }






                    }

                }
            }



            catch
            {
                MessageBox.Show("خطایی رخ داده است");
            }
        }































        //---End Block of Class And Namespace------------------------

    }
}