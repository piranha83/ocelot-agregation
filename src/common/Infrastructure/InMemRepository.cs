using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infrastructure.Abstractions;

namespace Infrastructure
{
    public class InMemRepository<TKey, T> : IRepository<TKey, T>
        where T : class
    {
        protected ConcurrentDictionary<TKey, T> _fake;
        public InMemRepository(ConcurrentDictionary<TKey, T> data) => _fake = data ?? new ConcurrentDictionary<TKey, T>();
        public async Task Update(TKey key, T item) => await Task.Run(() => _fake.AddOrUpdate(key, item, (id, o) => throw new NotImplementedException()));
        public async Task<IList<T>> Get(Func<T, bool> specification) => await Task.FromResult(_fake.Values.Where(specification).ToList());
        public async Task<T> Get(TKey key) => await Task.FromResult(_fake[key]);
    }
}