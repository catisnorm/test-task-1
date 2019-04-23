using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using TestWebApi.Data.Interface;

namespace TestWebApi.Data.Repository
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbSet<T> _dbSet;
        protected TestDbContext DataContext { get; }

        protected Repository(TestDbContext context)
        {
            DataContext = context;
            _dbSet = DataContext.Set<T>();
        }

        public virtual void Add(T item)
        {
            _dbSet.Add(item);
        }

        public virtual void Update(T item)
        {
            DataContext.Entry(item).State = EntityState.Modified;
        }

        public virtual void Delete(T item)
        {
            _dbSet.Remove(item);
        }

        public virtual IEnumerable<T> Get()
        {
            return _dbSet.ToList();
        }

        public virtual T Get<TKeyType>(TKeyType id)
        {
            return _dbSet.Find(id);
        }

        public virtual IEnumerable<T> Get(Expression<Func<T, bool>> filter)
        {
            IQueryable<T> query = _dbSet;

            query = query.Where(filter);

            return query.ToList();
        }
    }
}