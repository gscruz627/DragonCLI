using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonCLI.Dragons
{
    public class FirebirdDragon : Dragon
    {
        public FirebirdDragon(string name) : base(name)
        {
            Elements = ["Fire", "Nature"];
            Level = 1;
            GoldRate = 10;
            FormalName = "Firebird Dragon";
        }
    }
}
