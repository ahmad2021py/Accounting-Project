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
   public class CategoryRepository:EntityGenericRepository<Category> ,ICategoryRepository 
    {
        //-----Fields-------------
        private Accounting_DbContext db;
        //---------Methods-------------
        #region متد سازنده کلاس 
        public CategoryRepository(Accounting_DbContext context) : base(context)
        {
            db = context;
        }
        #endregion
       
      
      
        //---------------------------------------------

    }
}
