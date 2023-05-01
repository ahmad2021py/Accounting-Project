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

    public class UserRepository : IUserRepository
    {

        //------------Fields----------------
        private Accounting_DbContext db;


        //-------Methods--------------------------
        #region constructor
        public UserRepository(Accounting_DbContext context)
        {
            db = context;
        }
        #endregion


        #region UserExist
        public bool UserExist(string UserName)
        {
            try
            {

                IQueryable<User> query;
                query = db.User.Where(n => n.UserName == UserName).Select(n => n);

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
        //------------
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



        //-----------------------------------------------------------
        public bool UserExist(string userName, string userPassword)
        {
            try
            {

                IQueryable<User> query;
                query = db.User.Where(n => n.UserName == userName && n.User_Password == userPassword).Select(n => n);

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



        #region GetUserList
        public List<User> GetUserList()
        {

            return db.User.ToList();

        }



        #endregion


        #region ChangeUserPassword Method

        public bool ChangeUserPassword(User user, string newUserPassword)
        {

            try
            {

                User query = db.User.Where(n => n.UserName == user.UserName && n.User_Password == user.User_Password).Select(n => n).First();
                db.User.Attach(query);
                db.Entry(query).Entity.User_Password = newUserPassword;
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


        #region Delete User
        public bool DeleteUser(string userName)
        {
            try
            {
                var db_record = db.User.Where(n => n.UserName == userName).Select(n => n).First();
                db.Entry(db_record).State = EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion



        #region Insert Record To Users

        public bool InsertToUsers(User record)
        {
            try
            {
                db.User.Add(record);
                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion

        public List<User> GetUserListByUserIDFilter(int UserID)
        {
            try
            {
                List<User> List = db.User.Where(n => n.UserId == UserID).ToList();
                return List;

            }
            catch
            {
                throw new Exception();
            }

        }

        public List<User> GetUserListByUserNameFilter(string UserName)
        {
            try
            {
                List<User> List = db.User.Where(n => n.UserName == UserName).ToList();
                return List;

            }
            catch
            {
                throw new Exception();
            }

        }

        public List<User> GetUserListByUserRoleFilter(string Role)
        {
            try
            {
                List<User> List = db.User.Where(n => n.Role == Role).ToList();
                return List;

            }
            catch
            {
                throw new Exception();
            }

        }






    }
}





