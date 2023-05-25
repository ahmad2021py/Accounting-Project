using Accounting.DataLayer.Context;
using Accounting.DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Services
{
    public class EntityGenericRepository<T> : IEntityGenericRepository 
    {
        //------------Fields----------------


        #region  Accounting_DbContext db Field
        private Accounting_DbContext db;

        #endregion


        //-------Methods--------------------------
        #region constructor method
        public EntityGenericRepository(Accounting_DbContext context)
        {
            db = context;
        }
        #endregion


      


        #region GetEntity Generic-Method
        public T GetEntity<T>(Expression<Func<T, bool>> predicate) where T : class

        {
            T item = null;

            item = db.Set<T>().FirstOrDefault(predicate);

            return item;
        }

        #endregion

        //-------WORKED----------------
        #region IsExist Generic-Method
        public bool IsExist<TEntity>(Expression<Func<TEntity, bool>> predicate = null) where TEntity : class
        {
            IQueryable<TEntity> data = db.Set<TEntity>();
            return data.Any(predicate);
        }

        #endregion

        #region Add Generic-Method
        public bool Add<T>(T newItem) where T : class
        {
            try
            {
                db.Set<T>().Add(newItem);
                return true;
            }
            catch
            {
                return false;
            }
          
        }

        #endregion

        #region GetAll Generic-Method

        public IList<T> GetAll<T>(Expression<Func<T, bool>> predicate) where T : class
        {
            return db.Set<T>().Where(predicate).ToList();
        }



        #endregion


        #region Delete Generic-Method
        public async Task<bool> DeleteByCondition<TDelete>(Expression<Func<TDelete, bool>> expression) where TDelete : class
        {
            return await Task.Run(() =>
            {
                try
                {
                    var entity = db.Set<TDelete>().Where(expression).FirstOrDefault();
                    if (db.Entry<TDelete>(entity).State == EntityState.Detached)
                    {
                        db.Set<TDelete>().Attach(entity);
                    }

                    db.Set<TDelete>().Remove(entity);
                    return true;
                }
                catch
                {
                    return false;
                }

            });
        }


        #endregion

        #region Update Generic-Method
        public bool Update<T>(object Obj, Expression<Func<T, bool>> currentEntityFilter) where T : class

        {
            try
            {
                var dbRecord = db.Set<T>().FirstOrDefault(currentEntityFilter);
                db.Entry(dbRecord).CurrentValues.SetValues(Obj);


                return true;
            }

            catch
            {
                return false;
            }

        }



        #endregion

        //--------------------------------------































        //---End Block of Interface And Namespace------------------------


    }
}
