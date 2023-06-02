using Accounting.DataLayer.Entities;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Interfaces.IRepositories
{
    public interface IRegistrationRepository : IEntityGenericRepository
    {
        Task<bool> RegistrationIsValid(string username, string email);
        Task<string> GetUserPassword(string username, string email);

        Task<bool> UpdateRecord(Registration record);

        Task<bool> UpdatePasswordByUser(string UserName, string NewPassword);
























        //-----------------------------------------
    }




}




