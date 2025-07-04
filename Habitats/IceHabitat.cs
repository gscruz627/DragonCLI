using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DragonCLI.Habitats
{
    public class IceHabitat : Habitat
    {
        public IceHabitat()
        {
            Name = "Ice";
            AllowedElements = ["Ice"];
            Level = 1;
            MaxCapacity = 2;
            Gold = 0;
            MaxGoldCapacity = 15000;
            Occupants = [];
            GoldLastCollected = DateTime.Now;

        }
    }
}
