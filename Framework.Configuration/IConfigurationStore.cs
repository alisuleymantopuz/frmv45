using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Configuration
{
    public interface IConfigurationStore
    {
        T GetValue<T>(string key, DefineStatus status);
        string GetValue(string key, DefineStatus status);
        string GetStringValue(string key);
    }
}
