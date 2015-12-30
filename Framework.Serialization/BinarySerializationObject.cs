using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Serialization
{
    public class BinarySerializationObject : ISerializer<byte[], object>
    {
        public byte[] Serialize(object value)
        {
            MemoryStream memorystream = new MemoryStream();
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(memorystream, value);
            byte[] bytes = memorystream.ToArray();
            return bytes;
        }

        public object Deserialize(byte[] value, Type type = null)
        { 
            MemoryStream memoryStream = new MemoryStream(value);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            return binaryFormatter.Deserialize(memoryStream);
        }
    }
}
