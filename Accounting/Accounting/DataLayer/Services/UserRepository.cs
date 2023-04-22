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

    public class UserRepository : IUserRepository
    {

        //#############فیلد های کلاس ##############
        private Accounting_DbContext db;


        //############        متد های کلاس      #####################
        #region متد سازنده کلاس 
        public UserRepository(Accounting_DbContext context)
        {
            db = context;
        }
        #endregion
        //------------------------------------------------
        #region متد تست وجود یوزر در دیتابیس
        public bool UserExist(User user)
        {
            try
            {

                IQueryable<User> query;
                query = db.User.Where(n => n.UserName == user.UserName && n.User_Password == user.User_Password && n.Role == user.Role).Select(n => n);

                if (query.ToList().Count > 0)
                {
                    return true;

                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }


        }





        // public bool UserExist(int userid)
        //{


        //    IQueryable<User> myquery_user_table_model_A;
        //    myquery_user_table_model_A = db.User.Where(n => n.ID == userid).Select(n => n);
        //    if (myquery_user_table_model_A.ToList().Count > 0)
        //    {
        //        //foreach (var n in myquery_user_table_model_A)//برای پیمایش در رکورد های متغیر "کوری" که همان جدول یوزر برگردانده شده است 
        //        //{
        //        //    myvariable.id_user_logined = n.Id;//ذخیره ایدی در ی متغیر سراسری که از کلاس "مای وریبل" است

        //        //}
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }

        #endregion
        //------------------------------------------------
        #region متد دریافت لیست کاربران
        public List<User> GetUserList()
        {

            return db.User.ToList();

        }



        #endregion




    }
}

