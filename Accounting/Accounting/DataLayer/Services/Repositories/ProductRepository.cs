using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Services
{
    public class ProductRepository : EntityGenericRepository<Product>, IProductRepository, IEntityGenericRepository
    {
        //------------Fields----------------


        #region  Accounting_DbContext db Field
        private Accounting_DbContext db;
        #endregion
        //-------Methods--------------------------


        #region constructor method
        public ProductRepository(Accounting_DbContext context) : base(context)
        {
            db = context;
        }
        #endregion


        #region Update Generic-Method
       async public Task<bool> UpdateProduct(Product Obj, Expression<Func<Product, bool>> currentEntityFilter) 

        {
            return await Task.Run(() =>
            {
                try
            {
                var dbRecord = db.Set<Product>().FirstOrDefault(currentEntityFilter);
                Obj.id = dbRecord.id;
                db.Entry(dbRecord).CurrentValues.SetValues(Obj);
                 
                return true;
            }

            catch
            {
                return false;
            }
            });

        }



        #endregion


























        //---End Block of Class And Namespace------------------------
    }
}
