using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DragonCLI.Dragons
{
    public class FireDragon : Dragon
    {
        public FireDragon()
        {
            Name = "Test Name";
            Elements = ["Fire"];
            Level = 1;
            GoldRate = 5;
            FoodLevel = 0;
            FoodLevelMax = 5;
            Attacks = [];
        }


    }
}
