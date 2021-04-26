using System.IO;
using System.Xml.Serialization;

namespace Receiver
{
    class XmlToObjConverter<T>
    {
        public T XML2obj(string xml)
        {
            XmlSerializer ser = new XmlSerializer(typeof(T));
            using (TextReader reader = new StringReader(xml))
            {
                T result = (T)ser.Deserialize(reader);
                return result;
            }
        }
    }
}
