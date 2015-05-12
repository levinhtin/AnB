using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace AnB.Data.Repository
{
    public interface IBasicRepository : IDisposable
        
    {
        TEntity Create<TEntity>(TEntity Item) where TEntity : class;
        TEntity Get<TEntity>(int Id) where TEntity : class;
        IQueryable<TEntity> Gets<TEntity>() where TEntity : class;
        IQueryable<T> GetTop<T>(int Top) where T : class;
        IQueryable<TEntity> GetsIncluding<TEntity>(params Expression<Func<TEntity, object>>[] include) where TEntity : class;
        TEntity Update<TEntity>(TEntity Item) where TEntity : class;
        bool Delete<TEntity>(TEntity Item) where TEntity : class;
        bool Delete<TEntity>(int Id) where TEntity : class;
       
    }
}