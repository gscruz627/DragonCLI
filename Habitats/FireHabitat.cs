﻿using System;
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
            Name = "Fire";
            Level = 1;
            AllowedElements = ["Fire"];
            MaxCapacity = 2;
            Occupants = [];
            Gold = 0;
            MaxGoldCapacity = 5000;
            GoldLastCollected = DateTime.Now;
        }

    }
}
