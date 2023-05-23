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
    public class ProductRepository : IProductRepository
    {
        //------------Fields----------------
        private Accounting_DbContext db;


        //-------Methods--------------------------
        #region constructor
        public ProductRepository(Accounting_DbContext context)
        {
            db = context;
        }
        #endregion
        //------------
        public async Task<bool> ProductExist(int productId)
        {
            return await Task.Run(() =>
            {
                try
                {

                    IQueryable<Product> query;
                    query = db.Product.Where(n =>n.ProductId == productId).Select(n => n);

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



        //-----------------------------------------------------------
        #region Insert Record To Product

        public bool InsertToProduct(Product record)
        {
            try
            {
                db.Product.Add(record);
                return true;
            }
            catch
            {
                return false;
            }

        }

        #endregion


        #region Delete ProductRecord
        public bool DeleteProductRecord(int productId)
        {
            try
            {
                var db_record = db.Product.Where(n => n.ProductId == productId).Select(n => n).First();
                db.Entry(db_record).State = EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion


        #region Update Record

        public bool UpdateRecord(Product record)
        {

            try
            {

                Product dbRecord = db.Product.Where(n => n.ProductId == record.ProductId).Select(n => n).First();
                db.Product.Attach(dbRecord);
                db.Entry(dbRecord).Entity.ProductName = record.ProductName;
                db.Entry(dbRecord).Entity.Features = record.Features;
                db.Entry(dbRecord).Entity.Picture = record.Picture;
                db.Entry(dbRecord).Entity.Price = record.Price;
                db.Entry(dbRecord).Entity.Company = record.Company;
                db.Entry(dbRecord).Entity.Category = record.Category;
               

                //SAVE change
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


        #endregion



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




















        //---End Block of Class And Namespace------------------------
    }
}
