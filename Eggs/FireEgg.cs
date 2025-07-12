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
TargetDragonClassName = "Dragons.FireDragon";
            Cost = 100;
            HatchXP = 50;
            BreedingTime = TimeSpan.FromSeconds(30);
        }
    }
}
