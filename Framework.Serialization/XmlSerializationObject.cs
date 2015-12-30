using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Framework.Serialization
{
    public class XmlSerializationObject : ISerializer<string, object>
    {
        public string Serialize(object value)
        {
            Type type = value.GetType();

            XmlSerializer serializer = new XmlSerializer(type);

            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Encoding = new UnicodeEncoding(false, false);
            settings.Indent = false;
            settings.OmitXmlDeclaration = false;

            using (StringWriter textWriter = new StringWriter())
            {
                using (XmlWriter xmlWriter = XmlWriter.Create(textWriter, settings))
                {
                    serializer.Serialize(xmlWriter, value);
                }
                return textWriter.ToString();
            }
        }

        public object Deserialize(string value, Type type = null)
        {
            XmlSerializer serializer = new XmlSerializer(type);

            XmlReaderSettings settings = new XmlReaderSettings();

            using (StringReader textReader = new StringReader(value))
            {
                using (XmlReader xmlReader = XmlReader.Create(textReader, settings))
                {
                    return serializer.Deserialize(xmlReader);
                }
            }
        }
    }
}
