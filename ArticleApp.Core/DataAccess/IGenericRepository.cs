using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using ArticleApp.Core.Entities;

namespace ArticleApp.Core.DataAccess
{
    public interface IGenericRepository<T> where T : class, IEntity, new()
    {
        T Get(Expression<Func<T, bool>> filter);
        IList<T> GetList(Expression<Func<T, bool>> filter = null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
