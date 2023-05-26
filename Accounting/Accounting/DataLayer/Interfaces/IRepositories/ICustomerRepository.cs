using Accounting.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Interfaces
{
   public interface ICustomerRepository : IEntityGenericRepository
    {
      

        bool UpdateRecord(Customer record);
















































        //---End Block of Class And Namespace------------------------

    }
}
