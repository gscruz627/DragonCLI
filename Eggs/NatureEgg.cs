using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DragonCLI.Dragons;

namespace DragonCLI.Eggs
{
    public class NatureEgg : Egg
    {
        public NatureEgg() 
        {
            DragonName = "Nature Dragon Egg";
            Elements = ["Nature"];
            HatchingDuration = TimeSpan.FromMinutes(20);
TargetDragonClassName = "Dragons.NatureDragon";
            Cost = 500;
            HatchXP = 1000;
            BreedingTime = TimeSpan.FromMinutes(20);
        }
    }
}
