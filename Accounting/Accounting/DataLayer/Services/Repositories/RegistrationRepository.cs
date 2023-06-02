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
        //---------
        #region متد بررسی وجود ایمیل و پسورد در دیتابیس ، برای بازیابی پسورد
        async public Task<bool> RegistrationIsValid(string username, string email)
        {

            return await Task.Run(() =>
            {
                //    try
                //{


                var query = db.Registrations.Where(n => n.Email == email && n.UserName == username).Select(n => n).ToList();
                if (query.Count > 0)
                    return true;



                //}
                //catch
                //{
                //    return false;
                //}
                return false;
            });

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

        //------------


        #region Update Record

        async public Task<bool> UpdateRecord(Registration record)
        {
            return await Task.Run(() =>
            {

                //try
                //{

                Registration _dbRecord = db.Registrations.Where(n => n.RegistrationsCode == record.RegistrationsCode).Select(n => n).SingleOrDefault();
                if (_dbRecord == null)
                {
                    return false;
                }
                db.Registrations.Attach(_dbRecord);
                db.Entry(_dbRecord).Entity.Password = record.Password;
                db.Entry(_dbRecord).Entity.Role = record.Role;
                db.Entry(_dbRecord).Entity.ContactNumber = record.ContactNumber;
                db.Entry(_dbRecord).Entity.UserName = record.UserName;
                db.Entry(_dbRecord).Entity.Email = record.Email;
                db.Entry(_dbRecord).Entity.Name = record.Name;
                //SAVE change
                db.SaveChanges();
                return true;
                //}
                //catch
                //{
                //    return false;
                //}


            });



        }


        #endregion



        #region Update Password By USER Method

        async public Task<bool> UpdatePasswordByUser(string UserName, string NewPassword)
        {
            return await Task.Run(() =>
            {

                //try
                //{

                Registration _dbRecord = db.Registrations.Where(n => n.UserName == UserName).Select(n => n).First();
                db.Registrations.Attach(_dbRecord);
                db.Entry(_dbRecord).Entity.Password = NewPassword;

                //SAVE change
                db.SaveChanges();
                return true;
                //}
                //catch
                //{
                //    return false;
                //}


            });



        }


        #endregion









        //----------------------------------
    }
}
