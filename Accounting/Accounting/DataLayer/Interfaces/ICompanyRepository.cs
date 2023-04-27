using Accounting.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Interfaces
{
   public interface ICompanyRepository 
    {
         bool ComapnyExist(string CompanyName);
         bool InsertToCompany(Company record);
        bool DeleteCompany(string CompanyName);
        List<Company> GetCompanyList();

    }
}
