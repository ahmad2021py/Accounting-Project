using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces.IRepositories;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Services.Repositories
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



        async public Task<bool> UpdateProduct(Product Obj, Expression<Func<Product, bool>> currentEntityFilter)

        {
            return await Task.Run(() =>
            {

                var dbRecord = db.Set<Product>().FirstOrDefault(currentEntityFilter);
                Obj.Row = dbRecord.Row;
                db.Entry(dbRecord).CurrentValues.SetValues(Obj);

                return true;

            });

        }





















        //---End Block of Class And Namespace------------------------
    }
}
