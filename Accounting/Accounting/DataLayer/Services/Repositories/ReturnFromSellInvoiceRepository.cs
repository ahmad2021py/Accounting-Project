using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces.IRepositories;

namespace Accounting.DataLayer.Services.Repositories
{
    public class ReturnFromSellInvoiceRepository : EntityGenericRepository<ReturnFromSellIncoice>, IEntityGenericRepository, IReturnFromSellInvoiceRepository
    {
        Accounting_DbContext db;
        public ReturnFromSellInvoiceRepository(Accounting_DbContext context) : base(context)
        {
            db = context;
        }
    }
}
