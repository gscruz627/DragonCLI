using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DragonCLI.Dragons;

namespace DragonCLI.Eggs
{
    public class CloudEgg : Egg
    {
        public CloudEgg()
        {
            DragonName = "Cloud Dragon Egg";
            Elements = ["Water", "Fire"];
            HatchingDuration = TimeSpan.FromHours(7);
TargetDragonClassName = "Dragons.CloudDragon";
            Cost = Int32.MaxValue;
            HatchXP = 250;
            BreedingTime = TimeSpan.FromHours(5);
        }
    }
}
