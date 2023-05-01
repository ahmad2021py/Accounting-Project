using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces;
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
    public partial class frmUserRegistration : Form
    {




        //---- Methods ---------
        #region Method for validation frmUserRegistration textboxes
        bool TxtNull()
        {
            if (WorkWithTextboxes.TextBoxisNull(cbRole.Text))
            {
                MessageBox.Show("لطفا نقش کاربر را انتخاب کنید");
                return true;
            }
            else if (WorkWithTextboxes.TextBoxisNull(txtUserName.Text))
            {
                MessageBox.Show("لطفا فیلد نام کاربری را پر کنید");
                return true;
            }
            else if (WorkWithTextboxes.TextBoxisNull(txtUserPass.Text))
            {
                MessageBox.Show("لطفا فیلد رمز را پر کنید ");
                return true;
            }
            else if (WorkWithTextboxes.TextBoxisNull(txtMail.Text))
            {
                MessageBox.Show("لطفا فیلد ایمیل را پر کنید");
                return true;
            }

            else if (WorkWithTextboxes.TextBoxisNull(txtName.Text))
            {
                MessageBox.Show("لطفا فیلد نام  را پر کنید");
                return true;
            }
            else if (WorkWithTextboxes.TextBoxisNull(txtContactNo.Text))
            {
                MessageBox.Show("لطفا فیلد شماره  را پر کنید");
                return true;
            }

            return false;

        }
        #endregion
        //-----------
        #region Method For Reset textBoxes and other
        void Reset()
        {
            txtUserName.Text = "";
            txtUserPass.Text = "";
            txtContactNo.Text = "";
            txtName.Text = "";
            txtMail.Text = "";
           
            txtUserName.Focus();
        }
        #endregion
        //-------------
        #region Fill_RegistrationInstance
        Registration Fill_RegistrationInstance(Registration RegistrationRecord)
        {

            RegistrationRecord.Role = cbRole.Text;
            RegistrationRecord.UserName = txtUserName.Text;
            RegistrationRecord.User_Password = Encryption.EncryptPassword(txtUserPass.Text);
            RegistrationRecord.NameOfUser = txtName.Text;
            RegistrationRecord.Email = txtMail.Text;
            RegistrationRecord.ContactNo = txtContactNo.Text;
            RegistrationRecord.JoiningDate = DateTime.Now;
            return RegistrationRecord;
        }
        #endregion

        #region  Fill_UserInstance Method
        User Fill_UserInstance(User UserRecord)
        {

            UserRecord.Role = cbRole.Text;
            UserRecord.UserName = txtUserName.Text;
            UserRecord.User_Password = Encryption.EncryptPassword(txtUserPass.Text);

            return UserRecord;
        }
        #endregion





        public frmUserRegistration()
        {
            InitializeComponent();
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            using (UnitOfWork _UnitOfWork = new UnitOfWork())
            {
                IUserRepository _IUserRepository = _UnitOfWork.UserRepository;
                if (!TxtNull())
                {
                    if (!_IUserRepository.UserExist(txtUserName.Text))
                    {
                        using (UnitOfWork _unitOfWork = new UnitOfWork())
                        {
                            Registration RegistrationRecord = new Registration();
                            RegistrationRecord = Fill_RegistrationInstance(RegistrationRecord);
                            User UserRecord = new User();
                            UserRecord = Fill_UserInstance(UserRecord);

                            IRegistrationRepository _RegistrationRepository = _unitOfWork.RegistrationRepository;
                            IUserRepository _UserRepository = _unitOfWork.UserRepository;

                            if (_RegistrationRepository.InsertToRegistration(RegistrationRecord) && _UserRepository.InsertToUsers(UserRecord))
                            {
                                MessageBox.Show("رکورد با موفقیت ثبت شد");
                                _unitOfWork.Save();
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
                        MessageBox.Show("این نام کاربری از قبل وجود دارد");
                        txtUserName.Text = "";
                        txtUserName.Focus();
                    }
                }





            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا از حذف رکورد اطمینان دارید ؟", "تایید کردن", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                using (UnitOfWork _unitOfWork = new UnitOfWork())
                {
                    IRegistrationRepository _RegistrationRepository = _unitOfWork.RegistrationRepository;
                    IUserRepository _UserRepository = _unitOfWork.UserRepository;

                    if (_RegistrationRepository.DeleteRecord(txtUserName.Text) && _UserRepository.DeleteUser(txtUserName.Text))
                    {
                        MessageBox.Show("رکورد با موفقیت حذف شد");
                        Reset();

                    }
                    else
                    {
                        MessageBox.Show("خطایی رخ داده است");
                    }








                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (UnitOfWork _unitOfWork = new UnitOfWork())
            {
                IRegistrationRepository _registrationRepository = _unitOfWork.RegistrationRepository;
                Registration record = new Registration();
                record = Fill_RegistrationInstance(record);
                if (_registrationRepository.UpdateRecord(record))
                {
                    MessageBox.Show("رکورد با موفقیت  بروز شد");
                }
                else
                {
                    MessageBox.Show("خطایی رخ داده است");
                }

            }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork _unitOfWork = new UnitOfWork())
            {
                IUserRepository _UserRepository = _unitOfWork.UserRepository;
                IRegistrationRepository _registrationRepository = _unitOfWork.RegistrationRepository;
                if (_UserRepository.UserExist(txtUserName.Text))
                {
                    Registration ResultRecord = _registrationRepository.GetRecord(txtUserName.Text);
                    txtName.Text = ResultRecord.NameOfUser;
                    txtMail.Text = ResultRecord.Email;
                    txtContactNo.Text = ResultRecord.ContactNo;
                    txtUserPass.Text = ResultRecord.User_Password;
                }



            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }

}
