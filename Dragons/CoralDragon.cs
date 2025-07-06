using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DragonCLI.Dragons
{
    public class CoralDragon : Dragon
    {
        public CoralDragon(string name) : base(name)
        {
            Elements = ["Nature", "Water"];
            Level = 1;
            GoldRate = 12;
            FormalName = "Coral Dragon";
        }
    }
}
