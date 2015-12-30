using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Configuration
{
    public class AppSettingNotFoundException : SystemException
    {
        private string _notFoundedKey;

        public AppSettingNotFoundException(string key)
        {
            this._notFoundedKey = key;
        }

        public override string Message
        {
            get
            {

                if (!string.IsNullOrEmpty(_notFoundedKey))
                {
                    return string.Format(ConfigurationMessageResources.AppSettingNotFoundMessageWithKey, _notFoundedKey);
                }
                else
                {
                    return ConfigurationMessageResources.AppSettingNotFoundMessage;
                }
            }
        }
    }
}
