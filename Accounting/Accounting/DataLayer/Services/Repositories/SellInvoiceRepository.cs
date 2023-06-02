using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces.IRepositories;

namespace Accounting.DataLayer.Services.Repositories
{
    public class SellInvoiceRepository : EntityGenericRepository<SellInvoice>, IEntityGenericRepository, ISelllnvoiceRepository
    {
        Accounting_DbContext db;
        public SellInvoiceRepository(Accounting_DbContext context) : base(context)
        {
            db = context;
        }
    }
}
