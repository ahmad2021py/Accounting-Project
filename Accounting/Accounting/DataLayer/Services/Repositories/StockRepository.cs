using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces.IRepositories;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Services.Repositories
{
    public class StockRepository : EntityGenericRepository<Stock>, IStockRepository, IEntityGenericRepository
    {
        //------------Fields----------------


        #region  Accounting_DbContext db Field
        private Accounting_DbContext db;
        #endregion
        //-------Methods--------------------------


        #region constructor method
        public StockRepository(Accounting_DbContext context) : base(context)
        {
            db = context;
        }
        #endregion


        #region Update Generic-Method
        async public Task<bool> UpdateStock(StockEntityWithoutRowPropertyForUpdate Obj, Expression<Func<Stock, bool>> currentEntityFilter)

        {
            return await Task.Run(() =>
            {
                //try
                //{
                var dbRecord = db.Set<Stock>().FirstOrDefault(currentEntityFilter);
                if (dbRecord == null)
                {
                    return false;
                }
                db.Entry(dbRecord).CurrentValues.SetValues(Obj);

                return true;
                //}

                //catch
                //{
                //    return false;
                //}
            });

        }



        #endregion



        #region Update Stock ProductQuantity By frmSellInvoice
        async public Task<bool> UpdateStock(StockbyOnlyQuantityField Obj, Expression<Func<Stock, bool>> currentEntityFilter)

        {
            return await Task.Run(() =>
            {
                //try
                //{
                var dbRecord = db.Set<Stock>().FirstOrDefault(currentEntityFilter);

                db.Entry(dbRecord).CurrentValues.SetValues(Obj);

                return true;
                //}

                //catch
                //{
                //    return false;
                //}
            });

        }



        #endregion
    }
}
