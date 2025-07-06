using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DragonCLI.Dragons;

namespace DragonCLI.Eggs
{
    public class ButterflyEgg : Egg
    {
        public ButterflyEgg()
        {
            DragonName = "Butterfly Dragon Egg";
            Elements = ["Fire", "Nature"];
            HatchingTime = DateTime.Now.AddHours(15);
            TargetDragon = (name) => new ButterflyDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 30000;
            BreedingTime = TimeSpan.FromHours(9);
        }
    }
}
