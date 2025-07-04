using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonCLI.Habitats
{
    public class EarthHabitat : Habitat
    {
        public EarthHabitat()
        {
            Name = "Earth";
            AllowedElements = ["Earth"];
            Level = 1;
            MaxCapacity = 2;
            Gold = 0;
            MaxGoldCapacity = 500;
            Occupants = [];
            GoldLastCollected = DateTime.Now;
        }
    }
}
