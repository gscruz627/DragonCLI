using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonCLI.Dragons
{
    public class FlamingRockDragon : Dragon
    {
        public FlamingRockDragon(string name) : base(name)
        {
            Elements = ["Earth", "Fire"];
            Level = 1;
            GoldRate = 9;
            FormalName = "Flaming Rock Dragon";
        }
    }
}
