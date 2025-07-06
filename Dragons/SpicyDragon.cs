using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DragonCLI.Dragons
{
    public class SpicyDragon : Dragon
    {
        public SpicyDragon(string name) : base(name)
        {
            Elements = ["Fire", "Nature"];
            Level = 1;
            GoldRate = 9;
            FormalName = "Spicy Dragon";
        }
    }
}
