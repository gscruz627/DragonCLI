using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonCLI.Dragons
{
    public class MudDragon : Dragon
    {
        public MudDragon(string name) : base(name)
        {
            Elements = ["Earth", "Water"];
            Level = 1;
            GoldRate = 8;
            FormalName = "Mud Dragon";
        }
    }
}
