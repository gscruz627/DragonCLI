using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonCLI.Dragons
{
    public class NatureDragon : Dragon
    {
        public NatureDragon(string name) : base(name) 
        {
            Elements = ["Nature"];
            Level = 1;
            GoldRate = 9;
            FormalName = "Nature Dragon";
        }
    }
}
