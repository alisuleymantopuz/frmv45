using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Serialization
{
    public class JsonSerializationObject : ISerializer<string, object>
    {
        public string Serialize(object value)
        {
            return JsonConvert.SerializeObject(value, value.GetType(), Formatting.Indented, null);
        }

        public object Deserialize(string value, Type type = null)
        {
            return JsonConvert.DeserializeObject(value, type);
        }
    }
}
