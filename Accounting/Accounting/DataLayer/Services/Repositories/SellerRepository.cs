using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces.IRepositories;

namespace Accounting.DataLayer.Services.Repositories
{
    public class SellerRepository : EntityGenericRepository<Seller>, IEntityGenericRepository, ISellerRepository
    {
        Accounting_DbContext db;
        public SellerRepository(Accounting_DbContext Context) : base(Context)
        {
            db = Context;
        }

        //----------------------
    }
}
