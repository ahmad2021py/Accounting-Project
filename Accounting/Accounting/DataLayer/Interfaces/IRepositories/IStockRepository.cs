

using Accounting.DataLayer.Entities;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Interfaces.IRepositories
{
    public interface IStockRepository : IEntityGenericRepository
    {


        Task<bool> UpdateStock(StockEntityWithoutRowPropertyForUpdate Obj, Expression<Func<Stock, bool>> currentEntityFilter);
        Task<bool> UpdateStockProductQuantity(StockbyOnlyQuantityField Obj, Expression<Func<Stock, bool>> currentEntityFilter);


    }
}
