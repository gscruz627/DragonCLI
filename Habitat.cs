﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonCLI
{
    public abstract class Habitat
    {
        public string? Name { get; set; }
        public List<string>? AllowedElements { get; set; } = new();
        public int Level { get; set; }
        public int Capacity { get; set; }
        public int MaxCapacity { get; set; }
        public int Gold { get; set; }
        public int MaxGoldCapacity { get; set; }
        public DateTime? BuildingTime { get; set; }
        public DateTime? GoldLastCollected { get; set; }

        public List<Guid> Occupants { get; set; } = new();


        public void Upgrade()
        {
            this.Level = 2;
            this.MaxCapacity = 4;
            this.MaxGoldCapacity *= 4;
        }
        public int RetrieveGold()
        {
            int gold = Gold;
            GoldLastCollected = DateTime.Now;
            Gold = 0;
            return gold;
        }
    }
}
