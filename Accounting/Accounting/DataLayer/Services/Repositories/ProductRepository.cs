using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces.IRepositories;

namespace Accounting.DataLayer.Services.Repositories
{
    public class ProductRepository : EntityGenericRepository<Product>, IProductRepository, IEntityGenericRepository
    {
        //------------Fields----------------


        #region  Accounting_DbContext db Field
        private Accounting_DbContext db;
        #endregion
        //-------Methods--------------------------


        #region constructor method
        public ProductRepository(Accounting_DbContext context) : base(context)
        {
            db = context;
        }
        #endregion



        //---End Block of Class And Namespace------------------------
    }
}
