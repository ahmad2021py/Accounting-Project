using Accounting.DataLayer.Context;
using Accounting.DataLayer.Interfaces.IRepositories;
using Accounting.Utilities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Services.Repositories
{
    public class EntityGenericRepository<T> : IEntityGenericRepository
    {
        //------------Fields----------------


        #region  Accounting_DbContext db Field
        private Accounting_DbContext _db;

        #endregion


        //-------Methods--------------------------
        #region constructor method
        public EntityGenericRepository(Accounting_DbContext context)
        {
            _db = context;
        }
        #endregion


        #region IsExist Generic-Method
        public async Task<bool> IsExist<TEntity>(Expression<Func<TEntity, bool>> predicate = null) where TEntity : class
        {
            return await Task.Run(() =>
            {

                IQueryable<TEntity> data = _db.Set<TEntity>();
                return data.Any(predicate);
            });

        }

        #endregion



        #region Add Generic-Method
        public async Task<bool> Add<T>(T newItem) where T : class
        {
            return await Task.Run(() =>
            {

                //try
                //{
                _db.Set<T>().Add(newItem);
                return true;
                //}
                //catch
                //{
                //    return false;
                //}
            });
        }

        #endregion



        #region GetAll Generic-Method

        public async Task<IEnumerable<T>> GetAll<T>(Expression<Func<T, bool>> predicate) where T : class
        {


            return await Task.Run(() =>
            {
                return _db.Set<T>().Where(predicate).ToList<T>();
            });
        }



        #endregion



        #region GetEntity Generic-Method
        public async Task<T> GetEntity<T>(Expression<Func<T, bool>> predicate) where T : class

        {
            return await Task.Run(() =>
            {
                T item = null;

                item = _db.Set<T>().FirstOrDefault(predicate);

                return item;
            });
        }

        #endregion



        #region Delete Generic-Method
        public async Task<bool> DeleteByCondition<TDelete>(Expression<Func<TDelete, bool>> expression) where TDelete : class
        {
            return await Task.Run(() =>
            {
                
                var entity = _db.Set<TDelete>().Where(expression).FirstOrDefault();
                if (_db.Entry<TDelete>(entity).State == EntityState.Detached)
                {
                    _db.Set<TDelete>().Attach(entity);
                }

                _db.Set<TDelete>().Remove(entity);
                return true;
       

            });
        }


        #endregion



        #region Update Generic-Method
        async public Task<bool> UpdateMany<TEntity>(Expression<Func<TEntity, bool>> filterExpression, List<PropertyMap> maps) where TEntity : class
        {
            return await Task.Run(() =>
            {

                // Get the records to be updated depending on the filter expression
                var recordsToBeUpdated = _db.Set<TEntity>().Where(filterExpression).ToList();
                var value = recordsToBeUpdated.FirstOrDefault();
                if (value != null)
                {
                    var properties = value.GetType().GetProperties();
                    foreach (var entity in recordsToBeUpdated)
                    {
                        foreach (var map in maps)
                        {
                            properties.FirstOrDefault(x => x.Name == map.PropertyName)?
                                      .SetValue(entity, map.PropertyValue);
                        }
                        return true;


                    }
                }
                return false;
            });
        }


        #endregion


    }
}
