using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces;
using System;
using System.Collections.Generic;
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


    }
}
 