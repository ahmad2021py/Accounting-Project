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
    public class ProductSoldRepository :EntityGenericRepository<ProductSold> , IEntityGenericRepository , IProductSoldRepository
    {
      private  Accounting_DbContext db;
        public ProductSoldRepository(Accounting_DbContext Context): base(Context)
        {
            db = Context;
        }

























        //------------------------------------
    }
}
