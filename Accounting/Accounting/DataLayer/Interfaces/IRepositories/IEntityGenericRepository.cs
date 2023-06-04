using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Interfaces.IRepositories
{
    public interface IEntityGenericRepository
    {
        Task<IEnumerable<T>> GetAll<T>(Expression<Func<T, bool>> predicate) where T : class;
        Task<T> GetEntity<T>(Expression<Func<T, bool>> predicate) where T : class;

        Task<bool> Add<T>(T newItem) where T : class;
        Task<bool> Update<T>(object dto, Expression<Func<T, bool>> currentEntityFilter) where T : class;

        Task<bool> DeleteByCondition<TDelete>(Expression<Func<TDelete, bool>> expression) where TDelete : class;



        Task<bool> IsExist<TEntity>(Expression<Func<TEntity, bool>> predicate = null) where TEntity : class;




        





















            //---End Block of Interface And Namespace------------------------

        }
}
