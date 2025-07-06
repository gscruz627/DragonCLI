using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DragonCLI.Dragons
{
    public class ChameleonDragon : Dragon
    {
        public ChameleonDragon(string name) : base(name)
        {
            Elements = ["Electric", "Earth"];
            Level = 1;
            GoldRate = 10;
            FormalName = "Chameleon Dragon";
        }
    }
}
