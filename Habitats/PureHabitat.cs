using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonCLI.Habitats
{
    public class PureHabitat : Habitat
    {
        public PureHabitat()
        {
            Name = "Pure";
            AllowedElements = ["Pure"];
            Level = 1;
            MaxCapacity = 2;
            Gold = 0;
            MaxGoldCapacity = 80000;
            Occupants = [];
            GoldLastCollected = DateTime.Now;
        }

    }
}
