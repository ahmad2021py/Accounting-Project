using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Services
{
    public class RegistrationRepository : IRegistrationRepository
    {

        #region فیلد های کلاس
        private Accounting_DbContext db;
        #endregion

        //-------------------------------------
        #region متد سازنده کلاس 
        public RegistrationRepository(Accounting_DbContext context)
        {
            db = context;
        }
        #endregion
        //---------
        #region متد بررسی وجود ایمیل و پسورد در دیتابیس ، برای بازیابی پسورد
        public bool RegistrationIsValid(string username, string email)
        {


            try
            {

                IQueryable<Registration> query;
                query = db.Registration.Where(n => n.Email == email && n.UserName == username).Select(n => n);
                return true;



            }
            catch
            {
                return false;
            }


        }
        #endregion
        //------------------------------------------------
        #region متد دریافت رمز با نام کاربری و ایمیل
        public string GetUserPassword(string username, string email)
        {


            try
            {

                string Password;
                Password = db.Registration.Where(n => n.Email == email && n.UserName == username).Select(n => n.User_Password).ToString();
                return Password;
            }
            catch
            {
                return "Error";
            }


        }
        #endregion
        //----------------
        #region متد اضافه کردن رکورد به جدول ثبت نام

        public bool InsertToRegistration(Registration record)
        {
            try
            {
                db.Registration.Add(record);
                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion
        //------------
        #region Delete Registration Record

        public bool DeleteRecord(string _username)
        {
            try
            {
                Registration record = db.Registration.Where(n => n.UserName == _username).Select(n => n).First();
                db.Registration.Remove(record);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }

        #endregion

        #region Update Record

        public bool UpdateRecord(Registration record)
        {

            try
            {

                Registration _dbRecord = db.Registration.Where(n => n.UserName == record.UserName).Select(n => n).First();
                db.Registration.Attach(_dbRecord);
                db.Entry(_dbRecord).Entity.User_Password = record.User_Password;
                db.Entry(_dbRecord).Entity.Role = record.Role;
                db.Entry(_dbRecord).Entity.ContactNo = record.ContactNo;
                db.Entry(_dbRecord).Entity.NameOfUser = record.NameOfUser;
                db.Entry(_dbRecord).Entity.Email = record.Email;
                //SAVE change
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }






        }


        #endregion



        #region
     public   Registration GetRecord(string UserName)
        {

            try
            {
                Registration Db_Record = db.Registration.Where(n => n.UserName == UserName).Select(n => n).FirstOrDefault();
                return Db_Record;
            }

            catch
            {
                throw new Exception();
            }






        }


        #endregion
    }
}
