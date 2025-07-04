using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonCLI.Dragons
{
    public class VolcanoDragon : Dragon
    {
        public VolcanoDragon(string name) : base(name)
        {
            Elements = ["Earth", "Fire"];
            Level = 1;
            GoldRate = 11;
            FormalName = "Volcano Dragon";
        }
    }
}
