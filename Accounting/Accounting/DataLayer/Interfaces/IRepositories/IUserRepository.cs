using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Interfaces
{
    public interface IUserRepository:IEntityGenericRepository,IDisposable
    {

     
        Task<bool> ChangeUserPasswordByUser(User user, string newUserPassword);
        Task<bool> ChangeUserPasswordByAdmin(string userName, string newUserPassword);



    }
}
