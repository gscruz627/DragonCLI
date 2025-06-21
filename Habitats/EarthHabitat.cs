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
            Name = "Earth Habitat";
            AllowedElements = ["Earth"];
            Level = 1;
            Capacity = 0;
            MaxCapacity = 2;
            Occupants = [];
        }
    }
}
