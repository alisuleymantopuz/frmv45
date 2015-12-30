using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Configuration
{
    public class ConfigurationStore : IConfigurationStore
    {
        public T GetValue<T>(string key, DefineStatus status)
        {
            var appSetting = ConfigurationManager.AppSettings[key];
            if (string.IsNullOrWhiteSpace(appSetting) && status == DefineStatus.Required)
            {
                throw new AppSettingNotFoundException(key);
            }

            var converter = TypeDescriptor.GetConverter(typeof(T));

            return (T)(converter.ConvertFromInvariantString(appSetting));

        }

        public string GetValue(string key, DefineStatus status)
        {
            var appSetting = ConfigurationManager.AppSettings[key];
            if (string.IsNullOrWhiteSpace(appSetting) && status == DefineStatus.Required)
            {
                throw new AppSettingNotFoundException(key);
            }
            return appSetting;
        }

        public string GetStringValue(string key)
        {
            var appSetting = ConfigurationManager.AppSettings[key]; 
            return appSetting;
        }
    }
}
