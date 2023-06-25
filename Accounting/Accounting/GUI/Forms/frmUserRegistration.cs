using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces.IRepositories;
using Accounting.Utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Accounting.GUI.Forms
{
    public partial class frmUserRegistration : Form
    {




        //---- Methods ---------

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
            PboxAvatar.Image = Properties.Resources.icons8_user_100px;

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
            RegistrationRecord.Avatar = WorkWithImage.imageToByteArray(PboxAvatar.Image);
            return RegistrationRecord;
        }
        #endregion







        public frmUserRegistration()
        {
            InitializeComponent();
        }


        private async void btnRegister_Click(object sender, EventArgs e)
        {
            bool isNullResult = WorkWithStrings.StringIsNullOrEmptyOrWhiteSpace(txtContactNo.Text,
                txtFamily.Text,
                txtMail.Text,
                txtUserPass.Text,
                txtUserName.Text,
                cbRole.Text

                );

            if (isNullResult)
            {
                MessageBox.Show("ورودی نامعتبر");
                return;

            }


            bool IsValidateEmailResult = await WorkWithEmail.IsValidateEmail(txtMail.Text);
            if (!IsValidateEmailResult)
            {
                MessageBox.Show("لطفا یک ایمیل معتبر وارد کنید");
                return;
            }
            using (UnitOfWork _UnitOfWork = new UnitOfWork())
            {
                IUserRepository _IUserRepository = _UnitOfWork.UserRepository;

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



                    IRegistrationRepository _RegistrationRepository = _unitOfWork.RegistrationRepository;
                    IUserRepository _UserRepository = _unitOfWork.UserRepository;
                    User userRecord = new User
                    {
                        UserCode = int.Parse(txtRegistrationCode.Text),
                        UserName = txtUserName.Text,
                        Password = txtUserPass.Text,
                        Role = cbRole.Text
                    };

                    if (await _RegistrationRepository.Add<Registration>(RegistrationRecord) && await _UserRepository.Add<User>(userRecord))
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
            if (WorkWithStrings.StringIsNullOrEmptyOrWhiteSpace(txtRegistrationCode.Text))
            {
                MessageBox.Show("کد نامعتبر");
                return;
            }

            if (MessageBox.Show("آیا از حذف رکورد اطمینان دارید ؟", "تایید کردن", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

                //------Fill PropertyMap ------------

                List<PropertyMap> RegistrationPropertiesToUpdate = new List<PropertyMap> {


                new PropertyMap()
                {

                    PropertyName = "Avatar" ,
                    PropertyValue= WorkWithImage.imageToByteArray(PboxAvatar.Image)


                 } ,

                 new PropertyMap()
                {

                    PropertyName = "ContactNumber" ,
                    PropertyValue= txtContactNo.Text


                      } ,
                    new PropertyMap()
                     {

                    PropertyName = "Family" ,
                    PropertyValue= txtFamily.Text


                    } ,
                    new PropertyMap()
                     {

                    PropertyName = "Email" ,
                    PropertyValue= txtMail.Text ,


                    } ,
                    new PropertyMap()
                     {

                    PropertyName = "Name" ,
                    PropertyValue= txtName.Text ,


                    } ,
                    new PropertyMap()
                     {

                    PropertyName = "UserName" ,
                    PropertyValue= txtUserName.Text ,


                    } ,

                    new PropertyMap()
                     {

                    PropertyName = "Password" ,
                    PropertyValue= WorkWithEncryption.EncryptPassword(txtUserPass.Text)  ,


                    } ,
                    new PropertyMap()
                     {

                    PropertyName = "Role" ,
                    PropertyValue= cbRole.Text ,


                    } ,
                };
                //-----
                Registration RegistrationRecord = new Registration();
                int registrationCode = int.Parse(txtRegistrationCode.Text);
                bool RegistrationUpdateRecordResult = await _registrationRepository.UpdateMany<Registration>(n => n.RegistrationsCode == registrationCode, RegistrationPropertiesToUpdate);

                if (!RegistrationUpdateRecordResult)
                {
                    MessageBox.Show("خطایی در اپدیت رخ داده ");
                    return;

                }
                //------Fill PropertyMap ------------

                List<PropertyMap> userPropertiesToUpdate = new List<PropertyMap> {


                new PropertyMap()
                {

                    PropertyName = "UserCode" ,
                    PropertyValue= Convert.ToInt32(txtRegistrationCode.Text)


            } ,

                 new PropertyMap()
                {

                    PropertyName = "Role" ,
                    PropertyValue= cbRole.Text


            } ,
                    new PropertyMap()
                     {

                    PropertyName = "UserName" ,
                    PropertyValue= txtUserName.Text


            } ,
                    new PropertyMap()
                     {

                    PropertyName = "Password" ,
                    PropertyValue= WorkWithEncryption.EncryptPassword(txtUserPass.Text)


            }
                };
                //-----
                int userCode = int.Parse(txtRegistrationCode.Text);
                bool UserChangeUserPasswordResult = await _UserRepository.UpdateMany<User>(n => n.UserCode == userCode, userPropertiesToUpdate);
                if (!UserChangeUserPasswordResult)
                {
                    MessageBox.Show("خطایی در اپدیت رخ داده ");
                    return;
                }
                try
                {
                    _unitOfWork.Save();
                    MessageBox.Show("رکورد با موفقیت بروزرسانی شد");
                    Reset();
                }


                catch
                {
                    MessageBox.Show("خطایی در اپدیت رخ داده ");
                }



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
                PboxAvatar.Image = Image.FromFile(OFD.FileName);
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
