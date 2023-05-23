using Accounting.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Interfaces
{
   public interface ICustomerRepository
    {
        Task<bool> CustomerExist(long nationalCode);
        bool InsertToCustomer(Customer record);

        bool DeleteCustomerRecord(long nationalCode);

        bool UpdateRecord(Customer record);

        List<Customer> GetCustomerList();

        List<Customer> GetCustomerListByNationalCodeFilter(long nationalCode);
















































        //---End Block of Class And Namespace------------------------

    }
}
