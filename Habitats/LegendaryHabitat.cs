using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonCLI.Habitats
{
    public class LegendaryHabitat : Habitat
    {
        public LegendaryHabitat()
        {
            Name = "Legendary";
            AllowedElements = ["Lengendary"];
            Level = 1;
            MaxCapacity = 2;
            Gold = 0;
            MaxGoldCapacity = 750000;
            Occupants = [];
            GoldLastCollected = DateTime.Now;

        }
    }
}
