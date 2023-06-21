using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces.IRepositories;
using Accounting.Utilities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Accounting.GUI.Forms
{
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
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
            txtdebtor.Text = "";
            txtcreditor.Text = "";
            txtCustomerName.Focus();
        }




        private Customer Fill__CustomerRecord(Customer CustomerRecord)
        {
            decimal debte = decimal.Parse(txtdebtor.Text);

            CustomerRecord.debtor = debte;
            CustomerRecord.creditor = decimal.Parse(txtcreditor.Text);
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


        private List<PropertyMap> Fill__PropertyMapList()
        {
            List<PropertyMap> CustomerPropertiesToUpdate = new List<PropertyMap>()
            {
                new PropertyMap()
                {


                    PropertyName="debtor"  ,
                    PropertyValue=decimal.Parse(txtdebtor.Text)
        },
                new PropertyMap()
                {
                    PropertyName="creditor" ,
                    PropertyValue=decimal.Parse(txtcreditor.Text)
        },
                new PropertyMap()
                {

                    PropertyName="Name" ,
                    PropertyValue=txtCustomerName.Text
        } ,
                new PropertyMap()
                {
                    PropertyName="Phone" ,
                    PropertyValue=txtCustomerPhone.Text
                } ,
                new PropertyMap()
                {
                    PropertyName="State" ,
                    PropertyValue=cbStates.Text
                } ,
                new PropertyMap()
                {
                    PropertyName="ZipCode" ,
                    PropertyValue=txtCustomerZipCode.Text
                } ,
                new PropertyMap()
                {
                    PropertyName="Email" ,
                    PropertyValue=txtCustomerEmail.Text
                },

                new PropertyMap()
                {
                    PropertyName="City" ,
                    PropertyValue=txtCustomerCity.Text
                } ,
                new PropertyMap()
                {
                    PropertyName="Address" ,
                    PropertyValue= txtCustomerAddress.Text
                }
            };

            return CustomerPropertiesToUpdate;

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
                txtcreditor.Text = frmCustomerRecords._creditor;
                txtdebtor.Text = frmCustomerRecords._debtor;

                frmCustomerRecords = null;

            }

        }

        async private void btnUpdate_Click(object sender, EventArgs e)
        {

            bool isNullResult = WorkWithStrings.StringIsNullOrEmptyOrWhiteSpace(txtCustomerAddress.Text,
                  txtCustomerCity.Text,
                  txtCustomerEmail.Text,
                  txtCustomerName.Text,
                  txtcreditor.Text,
                  txtdebtor.Text,
                  cbStates.Text,
                  txtCustomerPhone.Text,
                  txtCustomerZipCode.Text,
                  txtNationalCode.Text);



            if (isNullResult)
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
                long nationalCode = long.Parse(txtNationalCode.Text);
                List<PropertyMap> CustomerPropertiesToUpdate = Fill__PropertyMapList();

                bool UpdateRecordResult = await _customerRepository.UpdateMany<Customer>(n => n.NationalCode == nationalCode, CustomerPropertiesToUpdate);
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

            if (WorkWithStrings.StringIsNullOrEmptyOrWhiteSpace(txtNationalCode.Text))
            {
                MessageBox.Show("ورودی یا ورودی های نامعتبر", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    if (!Result)
                    {

                        MessageBox.Show("مشتری با این کد ملی یافت نشد");
                        return;
                    }


                    bool DeleteResult = await _CustomerRepository.DeleteByCondition<Customer>(n => n.NationalCode == NationalCode);
                    if (DeleteResult)
                    {
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

        async private void btnSave_Click(object sender, EventArgs e)
        {

            bool isNullResult = WorkWithStrings.StringIsNullOrEmptyOrWhiteSpace(txtCustomerAddress.Text,
                txtCustomerCity.Text,
                txtCustomerEmail.Text,
                txtCustomerName.Text,
                txtcreditor.Text,
                txtdebtor.Text,
                cbStates.Text,
                txtCustomerPhone.Text,
                txtCustomerZipCode.Text,
                txtNationalCode.Text);



            if (isNullResult)
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

        private void cbStates_SelectedIndexChanged(object sender, EventArgs e)
        {

        }







































        //---End Block of Class And Namespace------------------------

    }
}
