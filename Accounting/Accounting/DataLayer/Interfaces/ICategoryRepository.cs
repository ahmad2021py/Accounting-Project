using Accounting.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Interfaces
{
  public  interface ICategoryRepository
    {
        bool CategoryExist(string CategoryName);
        bool InsertToCategory(Categories record);
        bool DeleteCategory(string CategoryName);
        List<Categories> GetCategoryList();



    }
}
