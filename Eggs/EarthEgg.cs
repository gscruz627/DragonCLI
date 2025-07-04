using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DragonCLI;
using DragonCLI.Dragons;

namespace DragonCLI.Eggs
{
    public class EarthEgg : Egg
    {
        public EarthEgg() 
        {
            DragonName = "Earth Dragon Egg";
            Elements = ["Earth"];
            HatchingTime = DateTime.Now;
            HatchingTime = HatchingTime.AddSeconds(15);
            TargetDragon = (name) => new EarthDragon(name);
            Cost = 100;
            HatchXP = 50;
            BreedingTime = TimeSpan.FromSeconds(15);
        }
    }
}
