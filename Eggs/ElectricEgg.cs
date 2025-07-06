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
            HatchingTime = DateTime.Now.AddMinutes(30);
            TargetDragon = (name) => new ElectricDragon(name);
            Cost = 4500;
            HatchXP = 5000;
            BreedingTime = TimeSpan.FromMinutes(30);
        }
    }
}
