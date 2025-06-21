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

        public List<Dragon> Occupants { get; set; }

        public void Upgrade()
        {
            this.MaxCapacity = 4;
        }
        public int RetrieveGold()
        {
            int total = 0;
            foreach (Dragon dragon in Occupants)
            {
                total += dragon.GoldProduced;
                dragon.GoldProduced = 0;
            }
            return total;

        }
    }
}
