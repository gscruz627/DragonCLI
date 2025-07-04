using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonCLI.Dragons
{
    public class WaterfallDragon : Dragon
    {
        public WaterfallDragon(string name) : base(name)
        {
            Elements = ["Earth", "Water"];
            Level = 1;
            GoldRate = 10;
            FormalName = "Waterfall Dragon";
        }
    }
}
