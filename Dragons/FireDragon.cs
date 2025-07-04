using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DragonCLI.Dragons
{
    public class FireDragon : Dragon
    {
        public FireDragon(string name) : base(name)
        {
            Elements = ["Fire"];
            Level = 1;
            GoldRate = 7;
            FormalName = "Fire Dragon";
        }


    }
}
