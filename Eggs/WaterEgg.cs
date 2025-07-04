using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DragonCLI.Dragons;

namespace DragonCLI.Eggs
{
    public class WaterEgg : Egg
    {
        public WaterEgg()
        {
            DragonName = "Water Dragon Egg";
            Elements = ["Water"];
            HatchingTime = DateTime.Now.AddSeconds(30);
            TargetDragon = (name) => new WaterDragon(name);
            Cost = 350;
            HatchXP = 250;
            BreedingTime = TimeSpan.FromSeconds(30);
        }
    }
}
