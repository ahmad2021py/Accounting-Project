using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces.IRepositories;
using System.Linq;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Services.Repositories
{
    public class RegistrationRepository : EntityGenericRepository<Registration>, IRegistrationRepository, IEntityGenericRepository
    {

        #region فیلد های کلاس
        private Accounting_DbContext db;
        #endregion

        //-------------------------------------
        #region متد سازنده کلاس 
        public RegistrationRepository(Accounting_DbContext context) : base(context)
        {
            db = context;
        }
        #endregion

        //------------------------------------------------
        #region متد دریافت رمز با نام کاربری و ایمیل
        async public Task<string> GetUserPassword(string username, string email)
        {
            return await Task.Run(() =>
            {
                string Password = db.Registrations.Where(n => n.Email == email && n.UserName == username).Select(n => n.Password).Single();
                return Password;
            });
        }

        #endregion
        //----------------












        //----------------------------------
    }
}
