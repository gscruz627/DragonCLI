using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonCLI
{
    public abstract class Egg
    {
        public string DragonName { get; set; }
        public List<string> Elements { get; set; }
        public DateTime HatchingTime { get; set; }
        public Func<string, Dragon> TargetDragon { get; set; }

        public Dragon Hatch(string name)
        {            
            return TargetDragon(name);
        }
    }
}
