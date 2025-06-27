using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DragonCLI.Dragons
{
    public class EarthDragon : Dragon
    {
        public EarthDragon(string name) : base(name)
        {
            Elements = ["Earth"];
            Level = 1;
            GoldRate = 18;
            FoodLevel = 0;
            FoodLevelMax = 5;
            Attacks = [];
            FormalName = "Earth Dragon";
        }
    }
}
