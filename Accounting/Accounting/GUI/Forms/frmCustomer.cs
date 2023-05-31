using Accounting.DataLayer.Context;
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
                 string.IsNullOrEmpty(txtCustomerAddress.Text) ||
                  string.IsNullOrEmpty(txtCustomerCity.Text) ||
                  string.IsNullOrEmpty(txtCustomerEmail.Text) ||
                  string.IsNullOrEmpty(txtCustomerName.Text) ||
                  string.IsNullOrWhiteSpace(txtCustomerPhone.Text) ||
                  string.IsNullOrWhiteSpace(txtCustomerZipCode.Text) ||
                  string.IsNullOrWhiteSpace(txtNationalCode.Text) ||
                  string.IsNullOrWhiteSpace(cbStates.Text)
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
            cbStates.Text = "";
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
            CustomerRecord.State = cbStates.Text;
            CustomerRecord.ZipCode = txtCustomerZipCode.Text;
            CustomerRecord.Email = txtCustomerEmail.Text;
            CustomerRecord.City = txtCustomerCity.Text;
            CustomerRecord.Address = txtCustomerAddress.Text;
            return CustomerRecord;

        }




    




        private void frmCustomer_Load(object sender, EventArgs e)
        {

            var list = WorkWithEnums.GetIranStatesList();
            foreach (string n in list)
            {
                cbStates.Items.Add(n);
            }





        }



        private void frmCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void txtNationalCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            // این چهار خط کد برای مجور کردن کاربر به وارد کردن فقط عدد است 
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back))
                e.Handled = true;
            else if (txtNationalCode.Text.Length == 10 && e.KeyChar != (char)Keys.Back && txtNationalCode.SelectedText.Length == 0)
                e.Handled = true;
        }

        private void btnShowfmCustomerRecords_Click(object sender, EventArgs e)
        {
            frmCustomerRecords frmCustomerRecords = new frmCustomerRecords();
            if (frmCustomerRecords.ShowDialog() == DialogResult.OK)
            {

                frmCustomerRecords.Close();
                txtNationalCode.Text = frmCustomerRecords._NationalCode;
                txtCustomerAddress.Text = frmCustomerRecords._Address;
                txtCustomerCity.Text = frmCustomerRecords._City;
                txtCustomerEmail.Text = frmCustomerRecords._Email;
                txtCustomerName.Text = frmCustomerRecords._Name;
                txtCustomerPhone.Text = frmCustomerRecords._Phone;
                cbStates.Text = frmCustomerRecords._State;
                txtCustomerZipCode.Text = frmCustomerRecords._ZipCode;

                frmCustomerRecords = null;

            }

        }

        async private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (IsNull())
            {
                MessageBox.Show("ورودی یا ورودی های نامعتبر", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool IsValidateEmailResult = await WorkWithEmail.IsValidateEmail(txtCustomerEmail.Text);
            if (!IsValidateEmailResult)
            {
                MessageBox.Show("لطفا یک ایمیل معتبر وارد کنید");
                return;
            }

          

            using (UnitOfWork _unitOfWork = new UnitOfWork())
            {
                ICustomerRepository _customerRepository = _unitOfWork.CustomerRepository;
                Customer Instance = new Customer();
                Instance = Fill__CustomerRecord(Instance);
                bool UpdateRecordResult = await _customerRepository.UpdateRecord(Instance);
                if (UpdateRecordResult)
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

        async private void btnDelete_Click(object sender, EventArgs e)
        {

            if (IsNull())
            {
                MessageBox.Show("ورودی یا ورودی های نامعتبر", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool IsValidateEmailResult = await WorkWithEmail.IsValidateEmail(txtCustomerEmail.Text);
            if (!IsValidateEmailResult)
            {
                MessageBox.Show("لطفا یک ایمیل معتبر وارد کنید");
                return;
            }

           

            if (MessageBox.Show("آیا از حذف رکورد اطمینان دارید ؟", "تایید کردن", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                bool nationalCodeValidation = WorkWithNationalCode.NationalCodeValidation(txtNationalCode.Text);

                if (!nationalCodeValidation)
                {
                    MessageBox.Show("کد ملی نامعتبر است");
                    return;
                }
                string nationalCode = WorkWithNationalCode.AddZeroToStartNationalCodeIfWant(txtNationalCode.Text);
                long NationalCode = long.Parse(nationalCode);
                using (UnitOfWork _unitOfWork = new UnitOfWork())
                {

                    ICustomerRepository _CustomerRepository = _unitOfWork.CustomerRepository;

                    bool Result = await _CustomerRepository.IsExist<Customer>(n => n.NationalCode == NationalCode);
                    if (Result)
                    {
                        bool DeleteResult = await _CustomerRepository.DeleteByCondition<Customer>(n => n.NationalCode == NationalCode);
                        if (DeleteResult)
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

        async private void btnSave_Click(object sender, EventArgs e)
        {

            if (IsNull())
            {
                MessageBox.Show("ورودی یا ورودی های نامعتبر", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool IsValidateEmailResult = await WorkWithEmail.IsValidateEmail(txtCustomerEmail.Text);
            if (!IsValidateEmailResult)
            {
                MessageBox.Show("لطفا یک ایمیل معتبر وارد کنید");
                return;
            }

            using (UnitOfWork _UnitOfWork = new UnitOfWork())
            {
                ICustomerRepository _CustomerRepository = _UnitOfWork.CustomerRepository;
               
                    bool nationalCodeValidation = WorkWithNationalCode.NationalCodeValidation(txtNationalCode.Text);

                    if (!nationalCodeValidation)
                    {
                        MessageBox.Show("کد ملی نامعتبر است");
                        return;
                    }
                    string nationalCode = WorkWithNationalCode.AddZeroToStartNationalCodeIfWant(txtNationalCode.Text);
                    long NationalCode = long.Parse(nationalCode);
                    bool Result = await _CustomerRepository.IsExist<Customer>(n => n.NationalCode == NationalCode);
                    if (!Result)
                    {
                        using (UnitOfWork _unitOfWork = new UnitOfWork())
                        {
                            Customer CustomerRecord = new Customer();
                            CustomerRecord = Fill__CustomerRecord(CustomerRecord);
                            bool AddResult = await _CustomerRepository.Add<Customer>(CustomerRecord);
                            if (AddResult)
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
                        return;
                    }
                }
               
            
        }



        private void btnNew_Click(object sender, EventArgs e)
        {
            Reset();
        }







































        //---End Block of Class And Namespace------------------------

    }
}
