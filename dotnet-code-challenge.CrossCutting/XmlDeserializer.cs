using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace dotnet_code_challenge.CrossCutting
{
    public class XmlDeserializer : Deserializer
    {
        public override T Deserialize<T>(string objectContent)
        {

            XmlSerializer serializer = new XmlSerializer(typeof(T));

            var xmlReaderWithContent = XmlReader.Create(new StringReader(objectContent));

            if (!serializer.CanDeserialize(xmlReaderWithContent))
                return default(T);

            return (T) serializer.Deserialize(xmlReaderWithContent);
        }
    }
}