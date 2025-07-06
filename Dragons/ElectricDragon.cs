using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DragonCLI.Dragons
{
    public class ElectricDragon : Dragon
    {
        public ElectricDragon(string name) : base(name)
        {
            Elements = ["Electric"];
            Level = 1;
            GoldRate = 12;
            FormalName = "Electric Dragon";
        }
    }
}
