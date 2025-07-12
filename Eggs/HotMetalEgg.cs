using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DragonCLI.Dragons;

namespace DragonCLI.Eggs
{
    public class HotMetalEgg : Egg
    {
        public HotMetalEgg()
        {
            DragonName = "Hot Metal Dragon Egg";
            Elements = ["Electric", "Fire"];
            HatchingDuration = TimeSpan.FromHours(15);
TargetDragonClassName = "Dragons.HotMetalDragon";
            Cost = Int32.MaxValue;
            HatchXP = 8000;
            BreedingTime = TimeSpan.FromHours(9);
        }
    }
}
