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
   public class CategoryRepository:ICategoryRepository
    {
        //-----Fields-------------
        private Accounting_DbContext db;
        //---------Methods-------------
        #region متد سازنده کلاس 
        public CategoryRepository(Accounting_DbContext context)
        {
            db = context;
        }
        #endregion
       
        #region متد تست وجود دسته بندی در دیتابیس
        public bool CategoryExist(string CategoryName)
        {
            try
            {

                IQueryable<Categories> query;
                query = db.Categories.Where(n => n.CategoryName == CategoryName).Select(n => n);

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

        #region متد اضافه کردن رکورد به جدول دسته بندی

        public bool InsertToCategory(Categories record)
        {
            try
            {
                db.Categories.Add(record);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion

        #region Delete Category Record
        public bool DeleteCategory(string CategoryName)
        {
            try
            {
                var db_record = db.Categories.Where(n => n.CategoryName == CategoryName).Select(n => n).First();
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

        #region متد دریافت لیست دسته بندی ها
        public List<Categories> GetCategoryList()
        {
            try
            {
                return db.Categories.ToList();

            }
            catch
            {
                throw new Exception();
            }

        }



        #endregion

        //---------------------------------------------

    }
}
