using System.Collections.Generic;

namespace MarqPontoExtension.Entities
{
    public class Configurator
    {
        public _Config Server { get; set; }
        public _Config AlertTime { get; set; }
        public _Config PopUpTime { get; set; }
        public _Config FadeAsDefault { get; set; }
        public _Config GadgetColor { get; set; }
        public _Config PopUpColor { get; set; }
        public _Config AlertColor { get; set; }
       // public _Config UserLogin { get; set; }

        public Configurator()
        {

        }

        public List<_Config> GetConfs()
        {
            var Confs = new List<_Config>();
            Confs.Add(Server);
            Confs.Add(AlertTime);
            Confs.Add(PopUpTime);
            Confs.Add(FadeAsDefault);
            Confs.Add(GadgetColor);
            Confs.Add(PopUpColor);
            Confs.Add(AlertColor);
           // Confs.Add(UserLogin);
            return Confs;
        }
    }
    public class _Config
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
