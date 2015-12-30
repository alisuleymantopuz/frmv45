using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Caching;

namespace Framework.StateStorage
{
    [Serializable]
    public class CacheItem
    {
        private object item;
        private CacheDependency cacheDependency;
        private DateTime absoluteExpiration;
        private TimeSpan slidingExpiration;
        private CacheItemPriority cacheItemPriority;
        private CacheItemRemovedCallback cacheItemRemovedCallback;

        public object Item
        {
            get
            {
                return this.item;
            }
        }

        public CacheDependency CacheDependency
        {
            get
            {
                return this.cacheDependency;
            }
        }

        public DateTime AbsoluteExpiration
        {
            get
            {
                return this.absoluteExpiration;
            }
        }

        public TimeSpan SlidingExpiration
        {
            get
            {
                return this.slidingExpiration;
            }
        }

        public CacheItemPriority CacheItemPriority
        {
            get
            {
                return this.cacheItemPriority;
            }
        }

        public CacheItemRemovedCallback CacheItemRemovedCallback
        {
            get
            {
                return this.cacheItemRemovedCallback;
            }
        }

        public CacheItem(object item, CacheDependency cacheDependency, DateTime absoluteExpiration, TimeSpan slidingExpiration, CacheItemPriority cacheItemPriority, CacheItemRemovedCallback cacheItemRemovedCallback)
        {
            this.item = item;
            this.cacheDependency = cacheDependency;
            this.absoluteExpiration = absoluteExpiration;
            this.slidingExpiration = slidingExpiration;
            this.cacheItemPriority = cacheItemPriority;
            this.cacheItemRemovedCallback = cacheItemRemovedCallback;
        }

        public CacheItem(object item)
        {
            this.item = item;
            this.cacheDependency = (CacheDependency)null;
            this.absoluteExpiration = Cache.NoAbsoluteExpiration;
            this.slidingExpiration = Cache.NoSlidingExpiration;
            this.cacheItemPriority = CacheItemPriority.NotRemovable;
            this.cacheItemRemovedCallback = (CacheItemRemovedCallback)null;
        }
    }
}
