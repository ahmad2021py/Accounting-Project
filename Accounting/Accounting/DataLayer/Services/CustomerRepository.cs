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
   public class CustomerRepository : ICustomerRepository
    {
        //------------Fields----------------
        private Accounting_DbContext db;


        //-------Methods--------------------------
        #region constructor
        public CustomerRepository(Accounting_DbContext context)
        {
            db = context;
        }


        #endregion
        //------------
        public async Task<bool> CustomerExist(long naturalCode)
        {
            return await Task.Run(() =>
            {
                try
                {

                    IQueryable<Customer> query;
                    query = db.Customer.Where(n => n.NationalCode == naturalCode).Select(n => n);

                    if (query.ToList().Count > 0)
                    {
                        return true;

                    }
                    else
                    {
                        return false;
                    }
                }
                catch
                {
                    return false;
                }

            });
        }

        public bool DeleteCustomerRecord(long nationalCode)
        {
            try
            {
                var db_record = db.Customer.Where(n => n.NationalCode == nationalCode).Select(n => n).First();
                db.Entry(db_record).State = EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Customer> GetCustomerList()
        {
            try
            {
                return db.Customer.ToList();

            }
            catch
            {
                throw new Exception();
            }
        }

        public List<Customer> GetCustomerListByNationalCodeFilter(long nationalCode)
        {
            try
            {
                List<Customer> List = db.Customer.Where(n => n.NationalCode == nationalCode).ToList();
                return List;

            }
            catch
            {
                throw new Exception();
            }

        }


        #region Insert Record To Customer

        public bool InsertToCustomer(Customer record)
        {
            try
            {
                db.Customer.Add(record);
                return true;
            }
            catch
            {
                return false;
            }

        }
        #endregion

        public bool UpdateRecord(Customer record)
        {
            try
            {

                Customer dbRecord = db.Customer.Where(n => n.NationalCode == record.NationalCode).Select(n => n).First();
                db.Customer.Attach(dbRecord);
                db.Entry(dbRecord).Entity.Name = record.Name;
                db.Entry(dbRecord).Entity.NationalCode = record.NationalCode;
                db.Entry(dbRecord).Entity.Phone = record.Phone;
                db.Entry(dbRecord).Entity.Address = record.Address;
                db.Entry(dbRecord).Entity.City = record.City;
                db.Entry(dbRecord).Entity.Email = record.Email;
                db.Entry(dbRecord).Entity.ZipCode = record.ZipCode;
                db.Entry(dbRecord).Entity.State = record.State;

             
                return true;
            }
            catch
            {
                return false;
            }




        }





















        //---End Block of Class And Namespace------------------------
    }
}
