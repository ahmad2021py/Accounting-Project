using System.Threading.Tasks;

namespace Accounting.DataLayer.Interfaces.IRepositories
{
    public interface IRegistrationRepository : IEntityGenericRepository
    {
        Task<string> GetUserPassword(string username, string email);

    }

}




