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
        bool ProductExist(string ProductName);
        bool InsertToProduct(Product record);
        bool DeleteProduct(string ProductName);

        List<Product> GetProductList();
        List<Product> GetProductListByCompanyFilter(string Company);
         List<Product> GetProductListByProductNameFilter(string ProductName);
        List<Product> GetProductListByCategoryFilter(string Category);
         bool UpdateRecord(Product record);
    }
}
