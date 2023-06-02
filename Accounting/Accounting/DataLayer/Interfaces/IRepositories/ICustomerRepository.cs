using Accounting.DataLayer.Entities;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Interfaces.IRepositories
{
    public interface ICustomerRepository : IEntityGenericRepository
    {


        Task<bool> UpdateRecord(Customer record);
















































        //---End Block of Class And Namespace------------------------

    }
}
