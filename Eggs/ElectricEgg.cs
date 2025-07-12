using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DragonCLI.Dragons;

namespace DragonCLI.Eggs
{
    public class ElectricEgg : Egg
    {
        public ElectricEgg()
        {
            DragonName = "Electric Dragon Egg";
            Elements = ["Electric"];
            HatchingDuration = TimeSpan.FromMinutes(30);
TargetDragonClassName = "Dragons.ElectricDragon";
            Cost = 4500;
            HatchXP = 5000;
            BreedingTime = TimeSpan.FromMinutes(30);
        }
    }
}
