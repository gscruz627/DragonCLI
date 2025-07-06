using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DragonCLI.Dragons;

namespace DragonCLI.Eggs
{
    public class CoralEgg : Egg
    {
        public CoralEgg()
        {
            DragonName = "Coral Dragon Egg";
            Elements = ["Water", "Nature"];
            HatchingTime = DateTime.Now.AddHours(15);
            TargetDragon = (name) => new CoralDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 5000;
            BreedingTime = TimeSpan.FromHours(9);
        }
    }
}
