using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Configuration
{
    public class FrameworkConfiguration
    {
        public IConfigurationStore ConfigurationStore { get; private set; }

        public FrameworkConfiguration(IConfigurationStore configurationStore)
        {
            ConfigurationStore = configurationStore;
        }

        public string ApplicationKey { get { return this.ConfigurationStore.GetStringValue("ApplicationKey"); } }

        public string ApplicationName { get { return this.ConfigurationStore.GetStringValue("ApplicationName"); } }

        public string ApplicationVersion { get { return this.ConfigurationStore.GetStringValue("ApplicationVersion"); } }

    }
}
