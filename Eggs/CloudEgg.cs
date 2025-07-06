using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DragonCLI.Dragons;

namespace DragonCLI.Eggs
{
    public class CloudEgg : Egg
    {
        public CloudEgg()
        {
            DragonName = "Cloud Dragon Egg";
            Elements = ["Water", "Fire"];
            HatchingTime = DateTime.Now.AddHours(7);
            TargetDragon = (name) => new CloudDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 250;
            BreedingTime = TimeSpan.FromHours(5);
        }
    }
}
