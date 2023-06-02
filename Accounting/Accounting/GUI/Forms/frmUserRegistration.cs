using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces.IRepositories;
using Accounting.Utilities;
using AccountingDLL;
using System;
using System.Drawing;
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
            RegistrationRecord.Name = txtName.Text;
            RegistrationRecord.RegistrationsCode = Convert.ToInt32(txtRegistrationCode.Text);
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
            UserRecord.UserCode = Convert.ToInt32(txtRegistrationCode.Text);

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


        private async void btnRegister_Click(object sender, EventArgs e)
        {
            bool IsValidateEmailResult = await WorkWithEmail.IsValidateEmail(txtMail.Text);
            if (!IsValidateEmailResult)
            {
                MessageBox.Show("لطفا یک ایمیل معتبر وارد کنید");
                return;
            }
            using (UnitOfWork _UnitOfWork = new UnitOfWork())
            {
                IUserRepository _IUserRepository = _UnitOfWork.UserRepository;
                if (TxtNull())
                {
                    MessageBox.Show("ورودی نامعتبر");
                    return;

                }
                bool RegistrationUserNameresult = await _IUserRepository.IsExist<Registration>(n => n.UserName == txtUserName.Text);
                int RegistrationCode = Convert.ToInt32(txtRegistrationCode.Text);
                bool txtRegistrationCoderesult = await _IUserRepository.IsExist<Registration>(n => n.RegistrationsCode == RegistrationCode);
                if (RegistrationUserNameresult || txtRegistrationCoderesult)
                {
                    MessageBox.Show("کاربر با ین مشخصات از قبل موجود است ");
                    return;

                }
                using (UnitOfWork _unitOfWork = new UnitOfWork())
                {
                    Registration RegistrationRecord = new Registration();
                    RegistrationRecord = Fill_RegistrationInstance(RegistrationRecord);
                    User UserRecord = new User();
                    UserRecord = Fill_UserInstance(UserRecord);

                    IRegistrationRepository _RegistrationRepository = _unitOfWork.RegistrationRepository;
                    IUserRepository _UserRepository = _unitOfWork.UserRepository;


                    if (await _RegistrationRepository.Add<Registration>(RegistrationRecord) && await _UserRepository.Add<User>(UserRecord))
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






        }

        async private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRegistrationCode.Text) || string.IsNullOrWhiteSpace(txtRegistrationCode.Text))
            {
                MessageBox.Show("کد نامعتبر");
                return;
            }

            if (MessageBox.Show("آیا از حذف رکورد اطمینان دارید ؟", "تایید کردن", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                using (UnitOfWork _unitOfWork = new UnitOfWork())
                {
                    IRegistrationRepository _RegistrationRepository = _unitOfWork.RegistrationRepository;
                    IUserRepository _UserRepository = _unitOfWork.UserRepository;
                    int RegistrationCode = Int32.Parse(txtRegistrationCode.Text);
                    bool RegistrationDeleteResult = await _RegistrationRepository.DeleteByCondition<Registration>(n => n.RegistrationsCode == RegistrationCode);
                    bool UserDeleteResult = await _UserRepository.DeleteByCondition<User>(n => n.UserCode == RegistrationCode);
                    if (RegistrationDeleteResult && UserDeleteResult)
                    {
                        _unitOfWork.Save();
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

        async private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool IsValidateEmailResult = await WorkWithEmail.IsValidateEmail(txtMail.Text);
            if (!IsValidateEmailResult)
            {
                MessageBox.Show("لطفا یک ایمیل معتبر وارد کنید");
                return;
            }
            using (UnitOfWork _unitOfWork = new UnitOfWork())
            {
                IRegistrationRepository _registrationRepository = _unitOfWork.RegistrationRepository;
                IUserRepository _UserRepository = _unitOfWork.UserRepository;


                Registration RegistrationRecord = new Registration();
                RegistrationRecord = Fill_RegistrationInstance(RegistrationRecord);
                bool RegistrationUpdateRecordResult = await _registrationRepository.UpdateRecord(RegistrationRecord);

                if (!RegistrationUpdateRecordResult)
                {
                    MessageBox.Show("خطایی در اپدیت رخ داده ");
                    return;

                }

                User user = new User();
                user = Fill_UserInstance(user);
                bool UserChangeUserPasswordResult = await _UserRepository.ChangeUserPasswordByAdmin(user);
                if (!UserChangeUserPasswordResult)
                {
                    MessageBox.Show("خطایی در اپدیت رخ داده ");
                    return;
                }

                MessageBox.Show("رکورد با موفقیت بروزرسانی شد");
                Reset();


            }
        }



        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            //try
            //{
            OpenFileDialog OFD = new OpenFileDialog();

            OFD.Filter = ("Image Files |*.png; *.bmp; *.jpg;*.jpeg; *.gif;");
            OFD.FilterIndex = 4;
            //Reset the file name
            OFD.FileName = "";

            if (OFD.ShowDialog() == DialogResult.OK)
            {
                PboxProductPicture.Image = Image.FromFile(OFD.FileName);
            }

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //}
        }

        private void frmUserRegistration_Load(object sender, EventArgs e)
        {
            Reset();
        }




        private void btnShowUserRecords_Click(object sender, EventArgs e)
        {
            frmUserReords frmUserReords = new frmUserReords();
            if (frmUserReords.ShowDialog() == DialogResult.OK)
            {
                frmUserReords.Close();
                this.txtRegistrationCode.Text = frmUserReords._UserCode;
                this.cbRole.Text = frmUserReords._Role;
                this.txtUserName.Text = frmUserReords._UserName;
                this.txtUserPass.Text = frmUserReords._Password;
                frmUserReords = null;



            }
        }

        private void frmUserRegistration_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }

}
