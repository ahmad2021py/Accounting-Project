using Accounting.DataLayer.Entities;
using System;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Interfaces.IRepositories
{
    public interface IUserRepository : IEntityGenericRepository, IDisposable
    {


        Task<bool> ChangeUserPasswordByUser(User user, string newUserPassword);
        Task<bool> ChangeUserPasswordByAdmin(User user);



    }
}
