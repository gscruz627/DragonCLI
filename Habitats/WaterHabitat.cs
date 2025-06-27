using DragonCLI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DragonCLI.Habitats
{

    public class WaterHabitat : Habitat
    {
        public WaterHabitat()
        {
            Name = "Water Habitat";
            AllowedElements = ["Water"];
            Level = 1;
            MaxCapacity = 2;
            Occupants = [];
            MaxGoldCapacity = 1;
            Gold = 0;
        }
    }
}