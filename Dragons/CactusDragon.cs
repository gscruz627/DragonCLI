using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DragonCLI.Dragons
{
    public class CactusDragon : Dragon
    {
        public CactusDragon(string name) : base(name)
        {
            Elements = ["Earth", "Nature"];
            Level = 1;
            GoldRate = 10;
            FormalName = "Cactus Dragon";
        }
    }
}
