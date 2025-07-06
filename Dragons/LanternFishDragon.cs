using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonCLI.Dragons
{
    public class LanternFishDragon : Dragon
    {
        public LanternFishDragon(string name) : base(name)
        {
            Elements = ["Electric", "Water"];
            Level = 1;
            GoldRate = 9;
            FormalName = "Lantern Fish Dragon";
        }
    }
}
