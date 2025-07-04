using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DragonCLI.Habitats
{
    public class ElectricHabitat : Habitat
    {
        public ElectricHabitat()
        {
            Name = "Electric";
            AllowedElements = ["Electric"];
            Level = 1;
            MaxCapacity = 2;
            Gold = 0;
            MaxGoldCapacity = 12500;
            Occupants = [];
            GoldLastCollected = DateTime.Now;

        }
    }
}
