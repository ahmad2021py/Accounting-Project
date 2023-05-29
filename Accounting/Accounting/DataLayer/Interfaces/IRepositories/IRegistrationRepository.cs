using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Interfaces
{
    public interface IRegistrationRepository : IEntityGenericRepository
    {
        Task<bool>  RegistrationIsValid(string username, string email);
        Task<string> GetUserPassword(string username, string email);
      
        Task<bool> UpdateRecord(Registration record);

        Task<bool> UpdatePasswordByUser(string UserName, string NewPassword);
    }




}




