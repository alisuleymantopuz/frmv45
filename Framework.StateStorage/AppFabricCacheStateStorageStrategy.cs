
using Microsoft.ApplicationServer.Caching;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Runtime.CompilerServices;

namespace Framework.StateStorage
{
    public class AppFabricCacheStateStorageStrategy : IStateStorageStrategy<string, CacheItem>
    {
        public StateStorageConfiguration StateStorageConfiguration { get; private set; }

        public DataCacheFactory Factory { get; private set; }

        public DataCache Cache { get; private set; }

        public AppFabricCacheStateStorageStrategy(StateStorageConfiguration stateStorageConfiguration)
        {
            this.StateStorageConfiguration = stateStorageConfiguration;
            this.Initialize();
        }


        private void Initialize()
        {
            if (string.IsNullOrEmpty(this.StateStorageConfiguration.AppFabricCacheHostName))
                throw new ConfigurationErrorsException("AppFabricCacheHostName should be declared in configuration for AppFabric Caching to work.");
            if (!this.StateStorageConfiguration.AppFabricCachePortNumber.HasValue)
                throw new ConfigurationErrorsException("AppFabricCachePortNumber should be declared in configuration for AppFabric Caching to work.");
         
            List<DataCacheServerEndpoint> list1 = new List<DataCacheServerEndpoint>();
            list1.Add(new DataCacheServerEndpoint(this.StateStorageConfiguration.AppFabricCacheHostName, this.StateStorageConfiguration.AppFabricCachePortNumber.Value));
           
            List<DataCacheServerEndpoint> list2 = list1;
            DataCacheFactoryConfiguration factoryConfiguration = new DataCacheFactoryConfiguration();
            factoryConfiguration.Servers = (IEnumerable<DataCacheServerEndpoint>)list2;
            factoryConfiguration.LocalCacheProperties = new DataCacheLocalCacheProperties();
           
            DataCacheFactoryConfiguration configuration = factoryConfiguration;
            int num = (int)DataCacheClientLogManager.ChangeLogLevel(TraceLevel.Off);
            this.Factory = new DataCacheFactory(configuration);
            this.Cache = this.Factory.GetCache("default");
            this.Cache.CreateRegion(this.StateStorageConfiguration.AppFabricCacheRegionForApplication);
        }


        public void Put(string key, CacheItem value)
        {
            this.Cache.Put(key, (object)value, this.StateStorageConfiguration.AppFabricCacheRegionForApplication);
        }

        public CacheItem Get(string key)
        {
            return (CacheItem)this.Cache.Get(key, this.StateStorageConfiguration.AppFabricCacheRegionForApplication);
        }

        public void Remove(string key)
        {
            this.Cache.Remove(key, this.StateStorageConfiguration.AppFabricCacheRegionForApplication);
        }
    }
}
