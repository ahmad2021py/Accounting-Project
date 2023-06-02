using Accounting.DataLayer.Context;
using Accounting.DataLayer.Entities;
using Accounting.DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Services
{
   public class CustomerRepository : EntityGenericRepository<Customer>, ICustomerRepository,IEntityGenericRepository
    {
        //------------Fields----------------
        private Accounting_DbContext db;


        //-------Methods--------------------------
        #region constructor
        public CustomerRepository(Accounting_DbContext context) : base(context)
        {
            db = context;
        }


        #endregion
        //------------


       async public Task<bool> UpdateRecord(Customer record)
        {
            return await Task.Run(() =>
            {
          

                Customer dbRecord = db.Customers.Where(n => n.NationalCode == record.NationalCode).Select(n => n).First();
                db.Customers.Attach(dbRecord);
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





















        //---End Block of Class And Namespace------------------------
    }
}
