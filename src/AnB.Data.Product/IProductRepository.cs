using AnB.Data.Repository;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace AnB.Data.Product
{
    public interface IProductRepository: IBasicRepository, IDisposable
    {
        IQueryable<T> GetTop<T>(int Top) where T : class;
    }
}