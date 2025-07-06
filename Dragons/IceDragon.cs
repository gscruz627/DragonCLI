using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonCLI.Dragons
{
    public class IceDragon : Dragon
    {
        public IceDragon(string name) : base(name)
        {
            Elements = ["Ice"];
            Level = 1;
            GoldRate = 4;
            FormalName = "Ice Dragon";
        }
    }
}
