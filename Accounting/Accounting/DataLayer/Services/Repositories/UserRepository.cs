using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces.IRepositories;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Services.Repositories
{

    public class UserRepository : EntityGenericRepository<User>, IUserRepository, IEntityGenericRepository, IDisposable
    {

        //------------Fields----------------
        private Accounting_DbContext db;


        //-------Methods--------------------------
        #region constructor
        public UserRepository(Accounting_DbContext context) : base(context)
        {
            db = context;
        }
        #endregion



        #region ChangeUserPassword By User Method

        async public Task<bool> ChangeUserPasswordByUser(User user, string newUserPassword)
        {
            return await Task.Run(() =>
            {

                //    try
                //{

                User query = db.Users.Where(n => n.UserName == user.UserName && n.Password == user.Password).Select(n => n).First();
                db.Users.Attach(query);
                db.Entry(query).Entity.Password = newUserPassword;
                //SAVE change
                db.SaveChanges();
                return true;
                //}
                //catch
                //{
                //    return false;
                //}

            });




        }


        #endregion






        #region ChangeUserPassword By Admin Method

        async public Task<bool> ChangeUserPasswordByAdmin(User user)
        {
            return await Task.Run(() =>
            {

                //try
                //{

                User query = db.Users.Where(n => n.UserCode == user.UserCode).Select(n => n).SingleOrDefault();
                if (query == null)
                {
                    return false;
                }
                db.Users.Attach(query);
                db.Entry(query).Entity.UserName = user.UserName;
                db.Entry(query).Entity.Password = user.Password;

                //SAVE change
                db.SaveChanges();
                return true;
                //}
                //catch
                //{
                //    return false;
                //}

            });




        }

        public void Dispose()
        {
            //Not an Object to Dispose
        }


        #endregion





















        //---------------------------------

    }
}





