using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces.IRepositories;
namespace Accounting.DataLayer.Services.Repositories
{
    public class CustomerRepository : EntityGenericRepository<Customer>, ICustomerRepository, IEntityGenericRepository
    {
        //------------Fields----------------
        private Accounting_DbContext db;


        //-------Methods--------------------------
        #region constructor
        public CustomerRepository(Accounting_DbContext context) : base(context)
        {
            db = context;
        }


        #endregion
        //------------








        //---End Block of Class And Namespace------------------------
    }
}
