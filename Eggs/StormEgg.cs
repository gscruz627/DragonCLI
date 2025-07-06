using DragonCLI.Dragons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DragonCLI.Dragons;

namespace DragonCLI.Eggs
{
    public class StormEgg : Egg
    {
        public StormEgg()
        {
            DragonName = "Storm Dragon Egg";
            Elements = ["Water", "Electric"];
            HatchingTime = DateTime.Now.AddHours(15);
            TargetDragon = (name) => new StormDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 5000;
            BreedingTime = TimeSpan.FromHours(9);
        }
    }
}
