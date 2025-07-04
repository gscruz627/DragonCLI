using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DragonCLI.Dragons;

namespace DragonCLI.Eggs
{
    public class VolcanoEgg : Egg
    {
        public VolcanoEgg()
        {
            DragonName = "Volcano Dragon Egg";
            Elements = ["Fire", "Earth"];
            HatchingTime = DateTime.Now.AddSeconds(30);
            TargetDragon = (name) => new VolcanoDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 250;
            BreedingTime = TimeSpan.FromMinutes(1);
        }
    }
}
