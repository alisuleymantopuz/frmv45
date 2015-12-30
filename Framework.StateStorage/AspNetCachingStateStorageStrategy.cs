using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Caching;

namespace Framework.StateStorage
{
    public class AspNetCachingStateStorageStrategy : IStateStorageStrategy<string, CacheItem>
    {
        private readonly Cache items;

        public AspNetCachingStateStorageStrategy()
        {
            this.items = HttpRuntime.Cache;

        }

        public void Put(string key, CacheItem value)
        {
            this.items.Insert(key, (object)value, value.CacheDependency, value.AbsoluteExpiration, value.SlidingExpiration, value.CacheItemPriority, value.CacheItemRemovedCallback);
        }

        public CacheItem Get(string key)
        {
            return this.items[key] as CacheItem;
        }

        public void Remove(string key)
        {
            this.items.Remove(key);
        }
    }
}
