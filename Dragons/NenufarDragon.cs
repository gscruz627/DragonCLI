using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonCLI.Dragons
{
    public class NenufarDragon : Dragon
    {
        public NenufarDragon(string name) : base(name)
        {
            Elements = ["Water", "Nature"];
            Level = 1;
            GoldRate = 6;
            FormalName = "Nenufar Dragon";
        }
    }
}
