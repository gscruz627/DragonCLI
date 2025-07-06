using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonCLI.Dragons
{
    public class StormDragon : Dragon
    {
        public StormDragon(string name) : base(name)
        {
            Elements = ["Water", "Electric"];
            Level = 1;
            GoldRate = 8;
            FormalName = "Storm Dragon";
        }
    }
}
