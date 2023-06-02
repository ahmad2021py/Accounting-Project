using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces.IRepositories;

namespace Accounting.DataLayer.Services.Repositories
{
    public class ProductSoldRepository : EntityGenericRepository<ProductSold>, IEntityGenericRepository, IProductSoldRepository
    {
        private Accounting_DbContext db;
        public ProductSoldRepository(Accounting_DbContext Context) : base(Context)
        {
            db = Context;
        }

























        //------------------------------------
    }
}
