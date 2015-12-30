using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Framework.StateStorage
{
    public class InMemoryStateStorageStrategy : IStateStorageStrategy<string, CacheItem>
    {
        private static Hashtable items;

        static InMemoryStateStorageStrategy()
        {
            InMemoryStateStorageStrategy.items = Hashtable.Synchronized(new Hashtable());
        }

        public InMemoryStateStorageStrategy()
        {

        }

        public void Put(string key, CacheItem value)
        {
            InMemoryStateStorageStrategy.items[(object)key] = (object)value;
        }

        public CacheItem Get(string key)
        {
            CacheItem cacheItem = (CacheItem)null;
            if (InMemoryStateStorageStrategy.items.ContainsKey((object)key))
                cacheItem = (CacheItem)InMemoryStateStorageStrategy.items[(object)key];
            return cacheItem;
        }

        public void Remove(string key)
        {
            if (!InMemoryStateStorageStrategy.items.ContainsKey((object)key))
                return;
            InMemoryStateStorageStrategy.items.Remove((object)key);
        }
    }
}
