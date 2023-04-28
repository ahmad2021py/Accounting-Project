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
    public class ProductRepository: IProductRepository
    {
        //------Fields---------------
        private Accounting_DbContext db;
      

        //--------Methods-------------------
        #region Class Constructor Method
        public ProductRepository(Accounting_DbContext context)
        {
            db = context;
        }
        #endregion

        #region ProductExist Method
        public bool ProductExist(string ProductName)
        {
            try
            {

                IQueryable<Product> query;
                query = db.Product.Where(n => n.ProductName == ProductName).Select(n => n);

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

        #region Insert Record ToProduct Method

        public bool InsertToProduct(Product record)
        {
            try
            {
                db.Product.Add(record);
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
        public bool DeleteProduct(string ProductName)
        {
            try
            {
                var db_record = db.Product.Where(n => n.ProductName == ProductName).Select(n => n).First();
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


        #region GetProductList method
        public List<Product> GetProductList()
        {
            try
            {
                return db.Product.ToList();

            }
            catch
            {
                throw new Exception();
            }

        }

        public List<Product> GetProductListByCompanyFilter(string Company)
        {
            try
            {
                List<Product> List = db.Product.Where(n => n.Company == Company).ToList();
                return List;

            }
            catch
            {
                throw new Exception();
            }

        }

        public List<Product> GetProductListByProductNameFilter(string ProductName)
        {
            try
            {
                List<Product> List = db.Product.Where(n => n.ProductName == ProductName).ToList();
                return List;

            }
            catch
            {
                throw new Exception();
            }

        }

        public List<Product> GetProductListByCategoryFilter(string Category)
        {
            try
            {
                List<Product> List = db.Product.Where(n => n.Category == Category).ToList();
                return List;

            }
            catch
            {
                throw new Exception();
            }

        }


        #endregion

        #region Update Record

        public bool UpdateRecord(Product record)
        {

            try
            {

                Product _dbRecord = db.Product.Where(n => n.ProductName == record.ProductName).Select(n => n).First();
                db.Product.Attach(_dbRecord);
                db.Entry(_dbRecord).Entity.ProductName = record.ProductName;
                db.Entry(_dbRecord).Entity.Category = record.Category;
                db.Entry(_dbRecord).Entity.Company = record.Company;
                
                //SAVE change
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }






        }


        #endregion

    }
}
