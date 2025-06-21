using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonCLI.Habitats
{
    public class FireHabitat : Habitat
    {
        public FireHabitat()
        {
            Name = "Fire Habitat";
            Level = 1;
            AllowedElements = ["Fire"];
            Capacity = 0;
            MaxCapacity = 2;
            Occupants = [];
        }

    }
}
