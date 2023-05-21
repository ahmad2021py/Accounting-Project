using Accounting.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Interfaces
{
    public interface IConfigRepository
    {
        Task<bool> ConfigExist(string productName);
        bool InsertToConfig(Config record);

        bool DeleteConfigRecord(string productName);

         bool UpdateRecord(Config record);

        List<Config> GetConfigList();

        List<Config> GetConfigListByProductNameFilter(string ProductName);




































        //---End Block of Interface And Namespace------------------------
    }
}
