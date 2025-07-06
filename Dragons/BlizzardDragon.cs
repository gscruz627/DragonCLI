using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonCLI.Dragons
{
    public class BlizzardDragon : Dragon
    {
        public BlizzardDragon(string name) : base(name)
        {
            Elements = ["Fire", "Water"];
            Level = 1;
            GoldRate = 7;
            FormalName = "Blizzard Dragon";
        }
    }
}
