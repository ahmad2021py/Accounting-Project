using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces.IRepositories;
using System;

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












        public void Dispose()
        {
            //Not an Object to Dispose
        }






















        //---------------------------------

    }
}





