using Accounting.DataLayer.Entities;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Interfaces.IRepositories
{
    public interface IProductRepository : IEntityGenericRepository
    {



        Task<bool> UpdateProduct(Product Obj, Expression<Func<Product, bool>> currentEntityFilter);















































        //---End Block of Interface And Namespace------------------------
    }
}
