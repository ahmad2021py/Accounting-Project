using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces.IRepositories;

namespace Accounting.DataLayer.Services.Repositories
{
    public class CompanyRepository : EntityGenericRepository<Company>, ICompanyRepository, IEntityGenericRepository
    {
        //------Feilds----------------------
        #region فیلد های کلاس
        private Accounting_DbContext db;
        #endregion

        //---------Methods-----------------
        #region متد سازنده کلاس 
        public CompanyRepository(Accounting_DbContext context) : base(context)
        {
            db = context;
        }
        #endregion




    }
}