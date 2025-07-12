using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DragonCLI.Dragons;

namespace DragonCLI.Eggs
{
    public class CactusEgg : Egg
    {
        public CactusEgg() 
        {
            DragonName = "Cactus Dragon Egg";
            Elements = ["Earth", "Nature"];
            HatchingDuration = TimeSpan.FromHours(9);
TargetDragonClassName = "Dragons.CactusDragon";
            Cost = Int32.MaxValue;
            HatchXP = 5000;
            BreedingTime = TimeSpan.FromHours(7);
        }
    }
}
