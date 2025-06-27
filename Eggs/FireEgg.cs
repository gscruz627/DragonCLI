using DragonCLI.Dragons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonCLI.Eggs
{
    public class FireEgg : Egg
    {
        public FireEgg()
        {
            DragonName = "Fire Dragon Egg";
            Elements = ["Fire"];
            HatchingTime = DateTime.Now;
            HatchingTime = HatchingTime.AddSeconds(30);
            TargetDragon = (name) => new FireDragon(name);
        }
    }
}
