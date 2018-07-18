using MarqPontoExtension.Entities;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MarqPontoExtension.Utils
{
    public static class XmlManager
    {
        private static OpenFileDialog FileDialog;

        public static string FindXmlPatch()
        {
            FileDialog = new OpenFileDialog();

            FileDialog.ShowDialog();
            FileDialog.OpenFile();

            return FileDialog.FileName;
        }

        public static void UpdateXml(Configurator configs)
        {
            var doc = XElement.Load(EnviormentInfo.GetXmlPathConf());

            #region Test Confs
            //Configurator configs = new Configurator()
            //{
            //    AlertColor = new _Config { Name = "AlertColor", Value = "Teste" },
            //    AlertTime = new _Config { Name = "AlertTime", Value = "Teste" },
            //    FadeAsDefault = new _Config { Name = "FadeAsDefault", Value = "Teste" },
            //    GadgetColor = new _Config { Name = "GadgetColor", Value = "Teste" },
            //    PopUpColor = new _Config { Name = "PopUpColor", Value = "Teste" },
            //    PopUpTime = new _Config { Name = "PopUpTime", Value = "Teste" },
            //    Server = new _Config { Name = "Server", Value = "Teste" },
            //};
            #endregion

            var confs = configs.GetConfs();

            confs.ForEach(conf =>
            {
                var elemento = doc
                    .Elements("Field")
                    .Where(e => e.Element("Name").Value == conf.Name)
                    .Single();

                elemento.SetElementValue("Value", conf.Value);
            });

            doc.Save(EnviormentInfo.GetXmlPathConf());

        }

        public static void GenereteXml()
        {
            if (!Directory.Exists(EnviormentInfo.GetXmlPath()))
            {
                Directory.CreateDirectory(EnviormentInfo.GetXmlPath());

                new XDocument
                (
                    new XElement("Fields",
                    new XElement("Field",
                    new XElement("Name", "Server"),
                    new XElement("Value", "https://jsonplaceholder.typicode.com/")),
                    new XElement("Field",
                    new XElement("Name", "AlertTime"),
                    new XElement("Value", "1")),
                    new XElement("Field",
                    new XElement("Name", "PopUpTime"),
                    new XElement("Value", "5")),
                    new XElement("Field",
                    new XElement("Name", "FadeAsDefault"),
                    new XElement("Value", "0")),
                    new XElement("Field",
                    new XElement("Name", "GadgetColor"),
                    new XElement("Value", "SteelBlue")),
                    new XElement("Field",
                    new XElement("Name", "PopUpColor"),
                    new XElement("Value", "Tomato")),
                    new XElement("Field",
                    new XElement("Name", "AlertColor"),
                    new XElement("Value", "Tomato")),
                    new XElement("Field",
                    new XElement("Name", "UserLogin"),
                    new XElement("Value", "")))

                ).Save(EnviormentInfo.GetXmlPath() + "\\conf.xml");
            }
        }
    }
}

