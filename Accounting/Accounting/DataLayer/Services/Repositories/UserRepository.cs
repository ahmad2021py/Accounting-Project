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

    public class UserRepository :EntityGenericRepository<User>, IUserRepository,IEntityGenericRepository
    {

        //------------Fields----------------
        private Accounting_DbContext db;


        //-------Methods--------------------------
        #region constructor
        public UserRepository(Accounting_DbContext context) :base(context)
        {
            db = context;
        }
        #endregion


      
        #region ChangeUserPassword Method

        public bool ChangeUserPassword(User user, string newUserPassword)
        {

            try
            {

                User query = db.Users.Where(n => n.UserName == user.UserName && n.Password == user.Password).Select(n => n).First();
                db.Users.Attach(query);
                db.Entry(query).Entity.Password = newUserPassword;
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




























        //---------------------------------

    }
}





