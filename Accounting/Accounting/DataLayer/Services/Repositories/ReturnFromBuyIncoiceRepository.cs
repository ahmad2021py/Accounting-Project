

using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces.IRepositories;

namespace Accounting.DataLayer.Services.Repositories
{
    public class ReturnFromBuyIncoiceRepository : EntityGenericRepository<ReturnFromBuyIncoice>, IEntityGenericRepository, IReturnFromBuyIncoiceRepository
    {
        private Accounting_DbContext _db;
        public ReturnFromBuyIncoiceRepository(Accounting_DbContext context) : base(context)
        {
            _db = context;
        }
    }
}
