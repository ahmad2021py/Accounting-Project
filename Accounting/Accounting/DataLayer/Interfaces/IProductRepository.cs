using Accounting.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Interfaces
{
    public interface IProductRepository
    {
        Task<bool> ProductExist(int productId);
        bool InsertToProduct(Product record);

        bool DeleteProductRecord(int productId);

        bool UpdateRecord(Product record);

        List<Product> GetProductList();

        List<Product> GetProductListByProductNameFilter(string ProductName);
        List<Product> GetProductListByCompanyFilter(string Company);
       
        List<Product> GetProductListByCategoryFilter(string Category);
       
      










































        //---End Block of Interface And Namespace------------------------
    }
}
