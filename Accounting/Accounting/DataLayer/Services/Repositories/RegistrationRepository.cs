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
    public class RegistrationRepository : EntityGenericRepository<Registration>, IRegistrationRepository , IEntityGenericRepository
    {

        #region فیلد های کلاس
        private Accounting_DbContext db;
        #endregion

        //-------------------------------------
        #region متد سازنده کلاس 
        public RegistrationRepository(Accounting_DbContext context) :base (context)
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
                Password = db.Registration.Where(n => n.Email == email && n.UserName == username).Select(n => n.Password).ToString();
                return Password;
            }
            catch
            {
                return "Error";
            }


        }
        #endregion
        //----------------
     
        //------------
  

        #region Update Record

        public bool UpdateRecord(Registration record)
        {

            try
            {

                Registration _dbRecord = db.Registration.Where(n => n.UserName == record.UserName).Select(n => n).First();
                db.Registration.Attach(_dbRecord);
                db.Entry(_dbRecord).Entity.Password = record.Password;
                db.Entry(_dbRecord).Entity.Role = record.Role;
                db.Entry(_dbRecord).Entity.ContactNumber = record.ContactNumber;
                db.Entry(_dbRecord).Entity.UserName = record.UserName;
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













        //----------------------------------
    }
}
