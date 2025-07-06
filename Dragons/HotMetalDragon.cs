using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonCLI.Dragons
{
    public class HotMetalDragon : Dragon
    {
        public HotMetalDragon(string name) : base(name)
        {
            Elements = ["Fire", "Electric"];
            Level = 1;
            GoldRate = 9;
            FormalName = "Hot Metal Dragon";
        }
    }
}
