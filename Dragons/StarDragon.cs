using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonCLI.Dragons
{
    public class StarDragon : Dragon
    {
        public StarDragon(string name) : base(name)
        {
            Elements = ["Earth", "Electric"];
            Level = 1;
            GoldRate = 15;
            FormalName = "Star Dragon";
        }
    }
}
