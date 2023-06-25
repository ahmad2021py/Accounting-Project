using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces.IRepositories;

namespace Accounting.DataLayer.Services.Repositories
{
    public class StockRepository : EntityGenericRepository<Stock>, IStockRepository, IEntityGenericRepository
    {
        //------------Fields----------------


        #region  Accounting_DbContext db Field
        private Accounting_DbContext db;
        #endregion
        //-------Methods--------------------------


        #region constructor method
        public StockRepository(Accounting_DbContext context) : base(context)
        {
            db = context;
        }
        #endregion






    }
}
