using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonCLI.Dragons
{
    public class GummyDragon : Dragon
    {
        public GummyDragon(string name) : base(name)
        {
            Elements = ["Nature", "Electric"];
            Level = 1;
            GoldRate = 12;
            FormalName = "Gummy Dragon";
            IsRare = true;
        }
    }
}
