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
    public class ConfigRepository : IConfigRepository
    {
        //------------Fields----------------
        private Accounting_DbContext db;


        //-------Methods--------------------------
        #region constructor
        public ConfigRepository(Accounting_DbContext context)
        {
            db = context;
        }
        #endregion
        //------------
        public async Task<bool> ConfigExist(string productName)
        {
            return await Task.Run(() =>
            {
                try
                {

                    IQueryable<Config> query;
                    query = db.Config.Where(n =>n.ProductName == productName).Select(n => n);

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
        #region Insert Record To Config

        public bool InsertToConfig(Config record)
        {
            try
            {
                db.Config.Add(record);
                return true;
            }
            catch
            {
                return false;
            }

        }

        #endregion


        #region Delete ConfigRecord
        public bool DeleteConfigRecord(string productName)
        {
            try
            {
                var db_record = db.Config.Where(n => n.ProductName == productName).Select(n => n).First();
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

        public bool UpdateRecord(Config record)
        {

            try
            {

                Config dbRecord = db.Config.Where(n => n.ProductName == record.ProductName).Select(n => n).First();
                db.Config.Attach(dbRecord);
                db.Entry(dbRecord).Entity.ProductName = record.ProductName;
                db.Entry(dbRecord).Entity.Features = record.Features;
                db.Entry(dbRecord).Entity.Picture = record.Picture;
                db.Entry(dbRecord).Entity.Price = record.Price;

                //SAVE change
                return true;
            }
            catch
            {
                return false;
            }






        }


        #endregion



        #region GetConfigList method
        public List<Config> GetConfigList()
        {
            try
            {
                return db.Config.ToList();

            }
            catch
            {
                throw new Exception();
            }

        }


        #endregion



        public List<Config> GetConfigListByProductNameFilter(string ProductName)
        {
            try
            {
                List<Config> List = db.Config.Where(n => n.ProductName == ProductName).ToList();
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
