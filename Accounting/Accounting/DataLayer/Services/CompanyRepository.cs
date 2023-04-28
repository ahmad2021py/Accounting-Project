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
    public class CompanyRepository : ICompanyRepository
    {
        //------Feilds----------------------
        #region فیلد های کلاس
        private Accounting_DbContext db;
        #endregion

       //---------Methods-----------------
        #region متد سازنده کلاس 
        public CompanyRepository(Accounting_DbContext context)
        {
            db = context;
        }
        #endregion
       

        #region متد تست وجود شرکت در دیتابیس
        public bool ComapnyExist(string CompanyName)
        {
            try
            {

                IQueryable<Company> query;
                query = db.Company.Where(n => n.CompanyName == CompanyName).Select(n => n);

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
        }
        #endregion
      
        #region متد اضافه کردن رکورد به جدول شرکت

        public bool InsertToCompany(Company record)
        {
            try
            {
                db.Company.Add(record);
                db.SaveChanges(); 
                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion


        #region Delete Record
        public bool DeleteCompany(string CompanyName) 
        {
            try
            {
                var db_record = db.Company.Where(n => n.CompanyName == CompanyName).Select(n => n).First();
                db.Entry(db_record).State = EntityState.Deleted;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion


        #region متد دریافت لیست شرکت ها
        public List<Company> GetCompanyList()
        {
            try
            {
                return db.Company.ToList();

            }
            catch
            {
                throw new Exception();
            }

        }



        #endregion



    }
}