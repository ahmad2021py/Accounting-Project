using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Interfaces
{
    public interface IProductRepository : IEntityGenericRepository
    {



         bool UpdateProduct(Product Obj, Expression<Func<Product, bool>> currentEntityFilter);















































        //---End Block of Interface And Namespace------------------------
    }
}
