using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace TestWebApi.Data.Interface
{
    public interface IRepository<T> where T : class
    {
        void Add(T item);
        void Update(T item);
        void Delete(T item);
        IEnumerable<T> Get();
        T Get<TKeyType>(TKeyType id);
        IEnumerable<T> Get(Expression<Func<T, bool>> filter);
    }
}
