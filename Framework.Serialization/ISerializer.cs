using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Serialization
{
    public interface ISerializer<T, T2>
    {
        T Serialize(T2 value);
        T2 Deserialize(T value, Type type = null);
    }
}
