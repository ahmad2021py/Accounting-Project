

using Accounting.DataLayer.Entities;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Interfaces
{
  public  interface IStockRepository  :IEntityGenericRepository
    {


          Task<bool> UpdateStock(Stock Obj, Expression<Func<Stock, bool>> currentEntityFilter);



    }
}
