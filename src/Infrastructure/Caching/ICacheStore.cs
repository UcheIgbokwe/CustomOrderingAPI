using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Caching
{
    public interface ICacheStore
    {
        void Add<TItem>(TItem item, ICacheKey<TItem> key, TimeSpan? expirationTime = null);

        void Add<TItem>(TItem item, ICacheKey<TItem> key, DateTime? absoluteExpiration = null);

        TItem Get<TItem>(ICacheKey<TItem> key) where TItem : class;

        void Remove<TItem>(ICacheKey<TItem> key);
    }
}