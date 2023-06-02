﻿using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces.IRepositories;
using Accounting.Utilities;
using System;
using System.Windows.Forms;

namespace Accounting.GUI.Forms
{
    public partial class frmSeller : Form
    {
        public frmSeller()
        {
            InitializeComponent();
        }






        private bool IsNull()
        {
            if (
                 string.IsNullOrEmpty(txtSellerAddress.Text) ||
                  string.IsNullOrEmpty(txtSellerCity.Text) ||
                  string.IsNullOrEmpty(txtSellerEmail.Text) ||
                  string.IsNullOrEmpty(txtSellerName.Text) ||
                  string.IsNullOrEmpty(txtcreditor.Text) ||
                  string.IsNullOrEmpty(txtdebtor.Text) ||
                    string.IsNullOrEmpty(cbStates.Text) ||
                     string.IsNullOrEmpty(txtSellerPhone.Text) ||
                        string.IsNullOrEmpty(txtSellerZipCode.Text) ||
                          string.IsNullOrEmpty(txtNationalCode.Text) ||

                   string.IsNullOrWhiteSpace(txtSellerAddress.Text) ||
                       string.IsNullOrWhiteSpace(txtSellerCity.Text) ||
                          string.IsNullOrWhiteSpace(txtSellerEmail.Text) ||
                          string.IsNullOrWhiteSpace(txtSellerName.Text) ||
                              string.IsNullOrWhiteSpace(txtcreditor.Text) ||
                              string.IsNullOrWhiteSpace(txtdebtor.Text) ||
                                string.IsNullOrWhiteSpace(cbStates.Text) ||
                  string.IsNullOrWhiteSpace(txtSellerPhone.Text) ||
                  string.IsNullOrWhiteSpace(txtSellerZipCode.Text) ||
                  string.IsNullOrWhiteSpace(txtNationalCode.Text)



                )

                return true;
            else
            {
                return false;
            }

        }




        private bool Validations()

        {



            if (!WorkWithStrings.TextToDecimalVlaidation(txtcreditor.Text))
            {
                // MessageBox.Show("تعداد نامعتبر");
                return false;
            }
            else if (!WorkWithStrings.TextToDecimalVlaidation(txtdebtor.Text))
            {

                // MessageBox.Show("قیمت نامعتبر");
                return false;


            }

            else if (!WorkWithStrings.TextToIntVlaidation(txtSellerZipCode.Text))
            {
                // MessageBox.Show("میزان تخفیف نامعتبر");
                return false;
            }




            return true;
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
            if (IsNull())
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
            if (string.IsNullOrEmpty(txtNationalCode.Text) || string.IsNullOrWhiteSpace(txtNationalCode.Text))
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
            if (IsNull())
            {
                MessageBox.Show("ورودی یا ورودی های نامعتبر", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Validations())
            {
                MessageBox.Show("مقادیر ورودی نامعتر");
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
                Instance = Fill__SellerRecord(Instance);
                bool UpdateRecordResult = await _SellerRepository.UpdateRecord(Instance);
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

















        //------------------------------------
    }
}