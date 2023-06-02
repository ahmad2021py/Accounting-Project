using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces.IRepositories;

namespace Accounting.DataLayer.Services.Repositories
{
  public  class BuyInvoiceRepository : EntityGenericRepository<BuyInvoice> , IEntityGenericRepository , IBuyInvoiceRepository
    {
        Accounting_DbContext db;
        public BuyInvoiceRepository(Accounting_DbContext context) : base(context)
        {
            db = context;
        }
    }
}
