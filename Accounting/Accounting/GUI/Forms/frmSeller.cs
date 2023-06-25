using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces.IRepositories;
using Accounting.Utilities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Accounting.GUI.Forms
{
    public partial class frmSeller : Form
    {
        public frmSeller()
        {
            InitializeComponent();
        }



        private void Reset()
        {
            txtNationalCode.Text = "";
            txtSellerName.Text = "";
            txtSellerPhone.Text = "";
            txtSellerEmail.Text = "";
            cbStates.Text = "";
            txtSellerCity.Text = "";
            txtSellerZipCode.Text = "";
            txtSellerAddress.Text = "";
            txtdebtor.Text = "";
            txtcreditor.Text = "";
            txtSellerName.Focus();
        }


        private Seller Fill__SellerRecord(Seller SellerRecord)
        {
            decimal debte = decimal.Parse(txtdebtor.Text);

            SellerRecord.debtor = debte;
            SellerRecord.creditor = decimal.Parse(txtcreditor.Text);
            SellerRecord.NationalCode = long.Parse(txtNationalCode.Text);
            SellerRecord.Name = txtSellerName.Text;
            SellerRecord.Phone = txtSellerPhone.Text;
            SellerRecord.State = cbStates.Text;
            SellerRecord.ZipCode = txtSellerZipCode.Text;
            SellerRecord.Email = txtSellerEmail.Text;
            SellerRecord.City = txtSellerCity.Text;
            SellerRecord.Address = txtSellerAddress.Text;
            return SellerRecord;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Reset();
        }

        async private void btnSave_Click(object sender, EventArgs e)
        {
            bool isNullResult = WorkWithStrings.StringIsNullOrEmptyOrWhiteSpace(txtNationalCode.Text,
                txtSellerZipCode.Text,
                txtSellerPhone.Text,
                cbStates.Text,
                txtdebtor.Text,
                txtcreditor.Text,
                txtSellerName.Text,
                txtSellerEmail.Text,
                txtSellerCity.Text,
                txtSellerAddress.Text
                );


            if (isNullResult)
            {
                MessageBox.Show("ورودی یا ورودی های نامعتبر", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool IsValidateEmailResult = await WorkWithEmail.IsValidateEmail(txtSellerEmail.Text);
            if (!IsValidateEmailResult)
            {
                MessageBox.Show("لطفا یک ایمیل معتبر وارد کنید");
                return;
            }



            using (UnitOfWork _UnitOfWork = new UnitOfWork())
            {
                ISellerRepository _SellerRepository = _UnitOfWork.SellerRepository;

                bool nationalCodeValidation = WorkWithNationalCode.NationalCodeValidation(txtNationalCode.Text);

                if (!nationalCodeValidation)
                {
                    MessageBox.Show("کد ملی نامعتبر است");
                    return;
                }
                string nationalCode = WorkWithNationalCode.AddZeroToStartNationalCodeIfWant(txtNationalCode.Text);
                long NationalCode = long.Parse(nationalCode);
                bool Result = await _SellerRepository.IsExist<Seller>(n => n.NationalCode == NationalCode);
                if (!Result)
                {
                    using (UnitOfWork _unitOfWork = new UnitOfWork())
                    {
                        Seller SellerRecord = new Seller();
                        SellerRecord = Fill__SellerRecord(SellerRecord);
                        bool AddResult = await _SellerRepository.Add<Seller>(SellerRecord);
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

        async private void btnDelete_Click(object sender, EventArgs e)
        {
            if (WorkWithStrings.StringIsNullOrEmptyOrWhiteSpace(txtNationalCode.Text))
            {
                MessageBox.Show("ورودی یا ورودی های نامعتبر", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }




            if (MessageBox.Show("آیا از حذف رکورد اطمینان دارید ؟", "تایید کردن", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

                    ISellerRepository _SellerRepository = _unitOfWork.SellerRepository;

                    bool Result = await _SellerRepository.IsExist<Seller>(n => n.NationalCode == NationalCode);
                    if (!Result)
                    {

                        MessageBox.Show("مشتری با این کد ملی یافت نشد");
                        return;
                    }


                    bool DeleteResult = await _SellerRepository.DeleteByCondition<Seller>(n => n.NationalCode == NationalCode);
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

        async private void btnUpdate_Click(object sender, EventArgs e)
        {

            bool isNullResult = WorkWithStrings.StringIsNullOrEmptyOrWhiteSpace(txtNationalCode.Text,
                txtSellerZipCode.Text,
                txtSellerPhone.Text,
                cbStates.Text,
                txtdebtor.Text,
                txtcreditor.Text,
                txtSellerName.Text,
                txtSellerEmail.Text,
                txtSellerCity.Text,
                txtSellerAddress.Text
                );


            if (isNullResult)
            {
                MessageBox.Show("ورودی یا ورودی های نامعتبر", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (!WorkWithStrings.StringToIntValidations(txtSellerZipCode.Text) || !WorkWithStrings.StringToDecimalValidations(txtdebtor.Text, txtcreditor.Text))
            {
                MessageBox.Show("مقادیر ورودی نامعتبر");
                return;

            }
            bool IsValidateEmailResult = await WorkWithEmail.IsValidateEmail(txtSellerEmail.Text);
            if (!IsValidateEmailResult)
            {
                MessageBox.Show("لطفا یک ایمیل معتبر وارد کنید");
                return;
            }



            using (UnitOfWork _unitOfWork = new UnitOfWork())
            {
                ISellerRepository _SellerRepository = _unitOfWork.SellerRepository;
                Seller Instance = new Seller();
                //------Fill PropertyMap ------------

                List<PropertyMap> SellerPropertiesToUpdate = new List<PropertyMap> {


                new PropertyMap()
                {

                    PropertyName = "Name" ,
                    PropertyValue= txtSellerName.Text


                 } ,

                 new PropertyMap()
                {

                    PropertyName = "Phone" ,
                    PropertyValue= txtSellerPhone.Text


                      } ,
                    new PropertyMap()
                     {

                    PropertyName = "Email" ,
                    PropertyValue= txtSellerEmail.Text


                    } ,
                    new PropertyMap()
                     {

                    PropertyName = "State" ,
                    PropertyValue= cbStates.Text ,


                    } ,
                    new PropertyMap()
                     {

                    PropertyName = "City" ,
                    PropertyValue= txtSellerCity.Text ,


                    } ,
                    new PropertyMap()
                     {

                    PropertyName = "ZipCode" ,
                    PropertyValue= txtSellerZipCode.Text ,


                    } ,
                    new PropertyMap()
                     {

                    PropertyName = "Address" ,
                    PropertyValue= txtSellerAddress.Text ,


                    } ,
                    new PropertyMap()
                     {

                    PropertyName = "debtor" ,
                    PropertyValue= decimal.Parse(txtdebtor.Text) ,


                    } ,
                    new PropertyMap()
                     {

                    PropertyName = "creditor" ,
                    PropertyValue= decimal.Parse(txtcreditor.Text) ,


                    } ,

                };
                //-----
                long nationalCode = long.Parse(txtNationalCode.Text);
                bool UpdateRecordResult = await _SellerRepository.UpdateMany<Seller>(n => n.NationalCode == nationalCode, SellerPropertiesToUpdate);
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

        private void btnShowfmSallerRecords_Click(object sender, EventArgs e)
        {
            frmSellerRecords frmSellerRecords = new frmSellerRecords();
            if (frmSellerRecords.ShowDialog() == DialogResult.OK)
            {

                frmSellerRecords.Close();
                txtNationalCode.Text = frmSellerRecords._NationalCode;
                txtSellerAddress.Text = frmSellerRecords._Address;
                txtSellerCity.Text = frmSellerRecords._City;
                txtSellerEmail.Text = frmSellerRecords._Email;
                txtSellerName.Text = frmSellerRecords._Name;
                txtSellerPhone.Text = frmSellerRecords._Phone;
                cbStates.Text = frmSellerRecords._State;
                txtSellerZipCode.Text = frmSellerRecords._ZipCode;
                txtcreditor.Text = frmSellerRecords._creditor;
                txtdebtor.Text = frmSellerRecords._debtor;

                frmSellerRecords = null;

            }

        }

        private void frmSeller_Load(object sender, EventArgs e)
        {
            var list = WorkWithEnums.GetIranStatesList();
            foreach (string n in list)
            {
                cbStates.Items.Add(n);
            }
        }

















        //------------------------------------
    }
}
