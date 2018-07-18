using System.Linq;
using System.Xml.Linq;

namespace MarqPontoExtension.Utils
{
    public static class XmlUtilities
    {
        public static string GetString(string fieldName)
        {
            XDocument xdoc = XDocument.Load(EnviormentInfo.GetXmlPathConf());
            return (string)(
                from el in xdoc.Descendants("Field")
                where (string)el.Element("Name") == fieldName
                select el.Element("Value")).FirstOrDefault();
        }

        public static int GetInt(string fieldName)
        {
            XDocument xdoc = XDocument.Load(EnviormentInfo.GetXmlPathConf());
            return (int)(
                from el in xdoc.Descendants("Field")
                where (string)el.Element("Name") == fieldName
                select el.Element("Value")).FirstOrDefault();
        }
    }
}
