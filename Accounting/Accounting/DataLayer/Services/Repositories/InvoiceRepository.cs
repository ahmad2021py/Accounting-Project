using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces.IRepositories;

namespace Accounting.DataLayer.Services.Repositories
{
    public class InvoiceRepository : EntityGenericRepository<SellInvoice>, IEntityGenericRepository, IInvoiceRepository
    {
        Accounting_DbContext db;
        public InvoiceRepository(Accounting_DbContext context) : base(context)
        {
            db = context;
        }
    }
}
