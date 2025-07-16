using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonCLI.Dragons
{
    public class ButterflyDragon : Dragon
    {
        public ButterflyDragon(string name) : base(name)
        {
            Elements = ["Fire", "Nature"];
            Level = 1;
            GoldRate = 10;
            FormalName = "Butterfly Dragon";
            IsSpecial = true;
        }
    }
}
