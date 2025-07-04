using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DragonCLI.Habitats
{
    public class DarkHabitat : Habitat
    {
        public DarkHabitat()
        {
            Name = "Dark";
            AllowedElements = ["Dark"];
            Level = 1;
            MaxCapacity = 2;
            Gold = 0;
            MaxGoldCapacity = 20000;
            Occupants = [];
            GoldLastCollected = DateTime.Now;

        }
    }
}
