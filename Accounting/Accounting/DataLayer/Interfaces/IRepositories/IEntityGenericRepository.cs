using Accounting.DataLayer.Context;
using Accounting.DataLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Interfaces
{
    public interface IEntityGenericRepository
    {
        IList<T> GetAll<T>(Expression<Func<T, bool>> predicate) where T : class;
        T GetEntity<T>(Expression<Func<T, bool>> predicate) where T : class;

        bool Add<T>(T newItem) where T : class;
        bool Update<T>(object dto, Expression<Func<T, bool>> currentEntityFilter) where T : class;

        Task<bool> DeleteByCondition<TDelete>(Expression<Func<TDelete, bool>> expression) where TDelete : class;



        bool IsExist<TEntity>(Expression<Func<TEntity, bool>> predicate = null) where TEntity : class;



        





















        //---End Block of Interface And Namespace------------------------

    }
}
