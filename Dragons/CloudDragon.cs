using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonCLI.Dragons
{
    public class CloudDragon : Dragon
    {
        public CloudDragon(string name) : base(name)
        {
            Elements = ["Fire", "Water"];
            Level = 1;
            GoldRate = 5;
            FormalName = "Cloud Dragon";
        }
    }
}
