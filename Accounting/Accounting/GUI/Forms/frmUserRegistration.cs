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

            else if (WorkWithTextboxes.TextBoxisNull(txtFamily.Text))
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
            cbRole.Text = "";
            txtUserName.Text = "";
            txtUserPass.Text = "";
            txtContactNo.Text = "";
            txtName.Text = "";
            txtFamily.Text = "";
            txtMail.Text = "";
            PboxProductPicture.Image = Properties.Resources.icons8_user_100px;

            txtUserName.Focus();
        }
        #endregion
        //-------------
        #region Fill_RegistrationInstance
        Registration Fill_RegistrationInstance(Registration RegistrationRecord)
        {

            RegistrationRecord.Role = cbRole.Text;
            RegistrationRecord.UserName = txtUserName.Text;
            RegistrationRecord.Password = WorkWithEncryption.EncryptPassword(txtUserPass.Text);
            RegistrationRecord.Family = txtFamily.Text;
            RegistrationRecord.Email = txtMail.Text;
            RegistrationRecord.ContactNumber = txtContactNo.Text;
            RegistrationRecord.JoiningDate = DateTime.Now;
            RegistrationRecord.Avatar = WorkWithImage.imageToByteArray(PboxProductPicture.Image);
            return RegistrationRecord;
        }
        #endregion

        #region  Fill_UserInstance Method
        User Fill_UserInstance(User UserRecord)
        {

            UserRecord.Role = cbRole.Text;
            UserRecord.UserName = txtUserName.Text;
            UserRecord.Password = WorkWithEncryption.EncryptPassword(txtUserPass.Text);

            return UserRecord;
        }
        #endregion





        public frmUserRegistration()
        {
            InitializeComponent();
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!WorkWithEmail.IsValidateEmail(txtMail.Text))
            {
                MessageBox.Show("لطفا یک ایمیل معتبر وارد کنید");
                return;
            }
                using (UnitOfWork _UnitOfWork = new UnitOfWork())
            {
                IUserRepository _IUserRepository = _UnitOfWork.UserRepository;
                if (!TxtNull())
                {
                    if (!_IUserRepository.IsExist<User>(n=>n.UserName==txtUserName.Text))
                    {
                        using (UnitOfWork _unitOfWork = new UnitOfWork())
                        {
                            Registration RegistrationRecord = new Registration();
                            RegistrationRecord = Fill_RegistrationInstance(RegistrationRecord);
                            User UserRecord = new User();
                            UserRecord = Fill_UserInstance(UserRecord);

                            IRegistrationRepository _RegistrationRepository = _unitOfWork.RegistrationRepository;
                            IUserRepository _UserRepository = _unitOfWork.UserRepository;

                            if (_RegistrationRepository.Add<Registration>(RegistrationRecord) && _UserRepository.Add<User>(UserRecord))
                            {
                                MessageBox.Show("رکورد با موفقیت ثبت شد");

                                _unitOfWork.Save();
                                Reset();
                            }
                            else
                            {
                                MessageBox.Show("خطایی رخ داده است");
                                Reset();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("این نام کاربری از قبل وجود دارد");
                        Reset();
                      
                      
                    }
                }





            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!WorkWithEmail.IsValidateEmail(txtMail.Text))
            {
                MessageBox.Show("لطفا یک ایمیل معتبر وارد کنید");
                return;
            }
            if (MessageBox.Show("آیا از حذف رکورد اطمینان دارید ؟", "تایید کردن", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                using (UnitOfWork _unitOfWork = new UnitOfWork())
                {
                    IRegistrationRepository _RegistrationRepository = _unitOfWork.RegistrationRepository;
                    IUserRepository _UserRepository = _unitOfWork.UserRepository;
                    string userName = txtUserName.Text;

                    if (_RegistrationRepository.DeleteByCondition<Registration>(n=>n.UserName== userName).Result && _UserRepository.DeleteByCondition<User>(n=>n.UserName==txtUserName.Text).Result)
                    {
                        MessageBox.Show("رکورد با موفقیت حذف شد");
                        Reset();

                    }
                    else
                    {
                        MessageBox.Show("خطایی رخ داده است");
                        Reset();
                    }








                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!WorkWithEmail.IsValidateEmail(txtMail.Text))
            {
                MessageBox.Show("لطفا یک ایمیل معتبر وارد کنید");
                return;
            }
            using (UnitOfWork _unitOfWork = new UnitOfWork())
            {
                IRegistrationRepository _registrationRepository = _unitOfWork.RegistrationRepository;
                Registration record = new Registration();
                record = Fill_RegistrationInstance(record);
                if (_registrationRepository.UpdateRecord(record))
                {
                    MessageBox.Show("رکورد با موفقیت  بروز شد");
                    Reset();
                }
                else
                {
                    MessageBox.Show("خطایی رخ داده است");
                    Reset();
                }

            }
        }

       

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog OFD = new OpenFileDialog();

                OFD.Filter = ("Image Files |*.png; *.bmp; *.jpg;*.jpeg; *.gif;");
                OFD.FilterIndex = 4;
                //Reset the file name
                OFD.FileName = "";

                if (OFD.ShowDialog() == DialogResult.OK)
                {
                    PboxProductPicture.Image = Image.FromFile(OFD.FileName);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
        }

        private void frmUserRegistration_Load(object sender, EventArgs e)
        {
            Reset();
        }

        private void txtMail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContactNo_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void frmUserRegistration_FormClosed(object sender, FormClosedEventArgs e)
        {
            WorkWithGlobalForms.frmMainMenu.Show();
            this.Hide();
        }

        private void btnShowUserRecords_Click(object sender, EventArgs e)
        {
            frmUserReords frm = new frmUserReords();
            frm.ShowDialog();
        }
    }

}
