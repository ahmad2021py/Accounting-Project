using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces;
using Accounting.DataLayer.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Services.Repositories
{
    public class InvoiceRepository : EntityGenericRepository<Invoice>, IEntityGenericRepository, IInvoiceRepository
    {
        Accounting_DbContext db;
        public InvoiceRepository( Accounting_DbContext context) : base(context)
        {
            db = context;
        }
    }
}
