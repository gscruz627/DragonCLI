using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonCLI.Dragons
{
    public class TropicalDragon : Dragon
    {
        public TropicalDragon(string name) : base(name)
        {
            Elements = ["Earth", "Nature"];
            Level = 1;
            GoldRate = 12;
            FormalName = "Tropical Dragon";
        }
    }
}
