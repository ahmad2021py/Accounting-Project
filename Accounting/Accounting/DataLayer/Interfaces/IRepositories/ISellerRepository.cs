using Accounting.DataLayer.Entities;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Interfaces.IRepositories
{
    public interface ISellerRepository : IEntityGenericRepository
    {

        Task<bool> UpdateRecord(Seller record);

    }
}
