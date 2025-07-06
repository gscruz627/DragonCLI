using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DragonCLI.Dragons;

namespace DragonCLI.Eggs
{
    public class TropicalEgg : Egg
    {
        public TropicalEgg()
        {
            DragonName = "Tropical Dragon Egg";
            Elements = ["Earth", "Nature"];
            HatchingTime = DateTime.Now.AddHours(13);
            TargetDragon = (name) => new TropicalDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 1000;
            BreedingTime = TimeSpan.FromHours(7);
        }
    }
}
