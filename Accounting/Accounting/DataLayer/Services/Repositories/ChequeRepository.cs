using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces.IRepositories;

namespace Accounting.DataLayer.Services.Repositories
{
    public class ChequeRepository : EntityGenericRepository<Cheque>, IEntityGenericRepository, IChequeRepository
    {
        //-----Fields-------------
        private Accounting_DbContext db;
        //---------Methods-------------
        public ChequeRepository(Accounting_DbContext context) : base(context)
        {
            db = context;
        }






























        //-----------------------------------
    }
}
