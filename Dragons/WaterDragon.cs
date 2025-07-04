using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonCLI.Dragons
{
    public class WaterDragon : Dragon
    {
        public WaterDragon(string name) : base(name)
        {
            Elements = ["Water"];
            Level = 1;
            GoldRate = 3;
            FormalName = "Water Dragon";
        }
    }
}
