using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DragonCLI.Habitats
{
    public class MetalHabitat : Habitat
    {
        public MetalHabitat()
        {
            Name = "Metal";
            AllowedElements = ["Metal"];
            Level = 1;
            MaxCapacity = 2;
            Gold = 0;
            MaxGoldCapacity = 17500;
            Occupants = [];
            GoldLastCollected = DateTime.Now;

        }
    }
}
