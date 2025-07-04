using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonCLI.Habitats
{
    public class NatureHabitat : Habitat
    {
        public NatureHabitat()
        {
            Name = "Nature";
            AllowedElements = ["Nature"];
            Level = 1;
            MaxCapacity = 2;
            Gold = 0;
            MaxGoldCapacity = 10000;
            Occupants = [];
            GoldLastCollected = DateTime.Now;

        }
    }
}
