using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Framework.Configuration;

namespace Framework.StateStorage
{
    public class StateStorageConfiguration
    {
        public IConfigurationStore IConfigurationStore { get; private set; }

        public StateStorageConfiguration(IConfigurationStore configurationStore)
        {
            this.IConfigurationStore = configurationStore;
        }


        public string AppFabricCacheHostName
        {
            get
            {
                return this.IConfigurationStore.GetValue<string>("AppFabricCacheHostName", DefineStatus.Required);
            }
        }

        public int? AppFabricCachePortNumber
        {
            get
            {
                return this.IConfigurationStore.GetValue<int?>("AppFabricCachePortNumber", DefineStatus.Optional);
            }
        }

        public string AppFabricCacheRegionForApplication
        {
            get
            {
                return this.IConfigurationStore.GetValue<string>("AppFabricCacheRegionForApplication", DefineStatus.Required);
            }
        }



    }
}
