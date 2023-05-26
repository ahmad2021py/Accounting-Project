using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Services
{
    public class CompanyRepository :EntityGenericRepository<Company>, ICompanyRepository,IEntityGenericRepository
    {
        //------Feilds----------------------
        #region فیلد های کلاس
        private Accounting_DbContext db;
        #endregion

       //---------Methods-----------------
        #region متد سازنده کلاس 
        public CompanyRepository(Accounting_DbContext context): base(context)
        {
            db = context;
        }
        #endregion
       

      

    }
}