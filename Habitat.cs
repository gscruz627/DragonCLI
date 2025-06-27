using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonCLI
{
    public abstract class Habitat
    {
        public string? Name { get; set; }
        public List<string>? AllowedElements { get; set; }
        public int Level { get; set; }
        public int Capacity { get; set; }
        public int MaxCapacity { get; set; }
        public int Gold { get; set; }
        public int MaxGoldCapacity { get; set; }

        public List<Dragon> Occupants { get; set; }

        public void Update()
        {
            if(Gold >= MaxGoldCapacity)
            {
                return;
            }
            else
            {
                int totalPlus = 0;
                foreach(var dragon in Occupants)
                {
                    totalPlus += dragon.GoldRate;
                }
                if ((Gold + totalPlus) > MaxGoldCapacity)
                {
                    Gold = MaxGoldCapacity;
                } else
                {
                    Gold += totalPlus;
                }
            }
        }

        public void Upgrade()
        {
            this.MaxCapacity = 4;
        }
        public int RetrieveGold()
        {
            int gold = Gold;
            Gold = 0;
            return gold;
        }
    }
}
