using AnB.Data.Repository;
using System;
using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace AnB.Data.Product
{
    public interface IEntity<TKey>
        where TKey : struct
    {
        TKey Id { get; set; }
    }

    public class ProductRepository<TEntity, TContext> : IDisposable
        where TEntity : class
        where TContext : DbContext
        {
        private readonly TContext context;
        public ProductRepository(DbContext dbContext)
        {
            context = dbContext as TContext;
        }

        public IQueryable<TEntity> GetTop(int Top)
        {
            return context.Set<TEntity>().Take(Top);
        }

        public TEntity Create(TEntity Item)
        {
            context.Set<TEntity>().Add(Item);
            context.SaveChanges();
            return Item;
        }
       
        public TEntity Get<TKey>(TKey value)
        {
            IQueryable<TEntity> dbSet = context.Set<TEntity>();
            var edmEntityType =
                ((IObjectContextAdapter)context)
                    .ObjectContext
                    .MetadataWorkspace
                    .GetItems<EntityType>(DataSpace.CSpace)
                    .Single(e => e.Name == typeof(TEntity).Name);

            PropertyInfo keyProperty =
                typeof(TEntity)
                    .GetProperty(
                        edmEntityType.KeyMembers.Single().Name,
                        BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

            var entityParameter = Expression.Parameter(typeof(TEntity), "e");

            var lambda =
                Expression.Lambda<Func<TEntity, bool>>(
                    Expression.Equal(
                        Expression.Property(entityParameter, keyProperty),
                // no cast required if the passed value is of the
                // same type as the key property
                        typeof(TKey) == keyProperty.PropertyType ?
                            (Expression)Expression.Constant(value) :
                            (Expression)Expression.Convert(
                                Expression.Constant(value), keyProperty.PropertyType)),
                        entityParameter);
            //return context.Set<TEntity>().FirstOrDefault();
            return dbSet.Where(lambda).FirstOrDefault();
        }

        public IQueryable<TEntity> Gets()
        {
            return context.Set<TEntity>();
        }

        public IQueryable<TEntity> GetsIncluding(params Expression<Func<TEntity, object>>[] include)
        {
            IQueryable<TEntity> retVal = context.Set<TEntity>();

            foreach (var item in include)
            {
                retVal = retVal.Include(item);
            }

            return retVal;
        }

        public TEntity Update(TEntity Item)
        {
            context.Set<TEntity>().Add(Item);
            context.SaveChanges();
            return Item;
        }

        public bool Delete(Expression<Func<TEntity, bool>> where = null)
        {
            TEntity item = context.Set<TEntity>().FirstOrDefault(where);
            context.Set<TEntity>().Remove(item);
            context.SaveChanges();
            return true;
        }

        //public bool Delete(Expression<Func<TKey, bool>> where = null)
        //{
        //    try
        //    {
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        return false;
        //    }
        //}

        public void Dispose()
        {
            if (context != null) context.Dispose();
        }
    }
}
