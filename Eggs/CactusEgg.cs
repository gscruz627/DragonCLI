using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DragonCLI.Dragons;

namespace DragonCLI.Eggs
{
    public class CactusEgg : Egg
    {
        public CactusEgg() 
        {
            DragonName = "Cactus Dragon Egg";
            Elements = ["Earth", "Nature"];
            HatchingTime = DateTime.Now.AddHours(9);
            TargetDragon = (name) => new CactusDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 5000;
            BreedingTime = TimeSpan.FromHours(7);
        }
    }
}
