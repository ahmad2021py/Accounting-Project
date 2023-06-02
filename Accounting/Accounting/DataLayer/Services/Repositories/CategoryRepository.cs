using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces.IRepositories;

namespace Accounting.DataLayer.Services.Repositories
{
    public class CategoryRepository : EntityGenericRepository<Category>, ICategoryRepository, IEntityGenericRepository
    {
        //-----Fields-------------
        private Accounting_DbContext db;
        //---------Methods-------------
        #region متد سازنده کلاس 
        public CategoryRepository(Accounting_DbContext context) : base(context)
        {
            db = context;
        }
        #endregion


























        //---------------------------------------------

    }
}
