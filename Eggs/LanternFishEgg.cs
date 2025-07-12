using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DragonCLI.Dragons;

namespace DragonCLI.Eggs
{
    public class LanternFishEgg : Egg
    {
        public LanternFishEgg()
        {
            DragonName = "Lantern Fish Dragon Egg";
            Elements = ["Water", "Electric"];
            HatchingDuration = TimeSpan.FromHours(13);
TargetDragonClassName = "Dragons.LanternFishDragon";
            Cost = Int32.MaxValue;
            HatchXP = 5000;
            BreedingTime = TimeSpan.FromHours(7);
        }
    }
}
