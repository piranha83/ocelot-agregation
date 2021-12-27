using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Abstractions
{
    public interface IRepository<TKey, T> where T : class
    {
        //Task<IList<T>> Get(Func<T, bool> specification);
        Task<T> Get(TKey key);
        Task Update(TKey key, T item);
    }

}