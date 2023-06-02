using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces.IRepositories;
using System.Linq;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Services.Repositories
{
    public class SellerRepository : EntityGenericRepository<Seller>, IEntityGenericRepository, ISellerRepository
    {
        Accounting_DbContext db;
        public SellerRepository(Accounting_DbContext Context) : base(Context)
        {
            db = Context;
        }



        async public Task<bool> UpdateRecord(Seller record)
        {
            return await Task.Run(() =>
            {


                Seller dbRecord = db.Sellers.Where(n => n.NationalCode == record.NationalCode).Select(n => n).FirstOrDefault();
                if (dbRecord == null)
                {
                    return false;
                }
                db.Sellers.Attach(dbRecord);
                db.Entry(dbRecord).Entity.Name = record.Name;
                db.Entry(dbRecord).Entity.NationalCode = record.NationalCode;
                db.Entry(dbRecord).Entity.Phone = record.Phone;
                db.Entry(dbRecord).Entity.Address = record.Address;
                db.Entry(dbRecord).Entity.City = record.City;
                db.Entry(dbRecord).Entity.Email = record.Email;
                db.Entry(dbRecord).Entity.ZipCode = record.ZipCode;
                db.Entry(dbRecord).Entity.State = record.State;
                db.Entry(dbRecord).Entity.debtor = record.debtor;
                db.Entry(dbRecord).Entity.creditor = record.creditor;
                return true;



            });

        }




























        //----------------------
    }
}
