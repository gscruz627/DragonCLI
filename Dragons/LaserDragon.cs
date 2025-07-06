using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonCLI.Dragons
{
    public class LaserDragon : Dragon
    {
        public LaserDragon(string name) : base(name)
        {
            Elements = ["Fire", "Electric"];
            Level = 1;
            GoldRate = 12;
            FormalName = "Laser Dragon";
        }
    }
}
