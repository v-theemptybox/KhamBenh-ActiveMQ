using System.IO;
using System.Xml.Serialization;

namespace Sender
{
    class XMLObjConverter<T>
    {
        public string object2XML(T p)
        {
            string xml = "";
            XmlSerializer ser = new XmlSerializer(typeof(T));
            using (MemoryStream ms = new MemoryStream())
            {
                ser.Serialize(ms, p);
                ms.Position = 0;
                xml = new StreamReader(ms).ReadToEnd();
            }
            return xml;
        }
        public T XML2object(string xml)
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
