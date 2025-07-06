using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DragonCLI.Dragons;

namespace DragonCLI.Eggs
{
    public class BlizzardEgg : Egg
    {
        public BlizzardEgg()
        {
            DragonName = "Blizzard Dragon Egg";
            Elements = ["Water", "Fire"];
            HatchingTime = DateTime.Now.AddHours(2);
            TargetDragon = (name) => new BlizzardDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 1000;
            BreedingTime = TimeSpan.FromHours(2);
        }
    }
}
