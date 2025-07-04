using DragonCLI.Dragons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DragonCLI.Dragons;

namespace DragonCLI.Eggs
{
    public class FlamingRockEgg : Egg
    {
        public FlamingRockEgg()
        {
            DragonName = "Flaming Rock Dragon Egg";
            Elements = ["Earth", "Fire"];
            HatchingTime = DateTime.Now.AddSeconds(30);
            TargetDragon = (name) => new FlamingRockDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 50;
            BreedingTime = TimeSpan.FromSeconds(30);
        }
    }
}
