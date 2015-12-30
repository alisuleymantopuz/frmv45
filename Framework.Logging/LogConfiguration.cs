using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Configuration;

namespace Framework.Logging
{
    public class LogConfiguration
    {
        public IConfigurationStore ConfigurationStore { get; private set; }

        public LogConfiguration(IConfigurationStore configurationStore)
        {
            this.ConfigurationStore = configurationStore;
        }     

        public int LoggerLevel
        {
            get
            {
                return this.ConfigurationStore.GetValue<int>("LoggerLevel", DefineStatus.Required);
            }
        }

        public string LogFilesRootFolder
        {
            get
            {
                return this.ConfigurationStore.GetValue<string>("LogFilesRootFolder", DefineStatus.Required); 
            }
        }

        public string LoggerApplicationName
        {
            get
            {
                return this.ConfigurationStore.GetValue<string>("LoggerApplicationName", DefineStatus.Required); 
            }
        }

        public string LogDatabaseConnectionString
        {
            get 
            {
                return this.ConfigurationStore.GetValue<string>("LogDatabaseConnectionString", DefineStatus.Optional); 
            }
        }

        public string LogDatabaseProvider
        {
            get 
            {
                return this.ConfigurationStore.GetValue<string>("LogDatabaseProvider", DefineStatus.Optional); 
            }
        }
    }
}
