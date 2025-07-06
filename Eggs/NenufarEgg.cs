using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DragonCLI.Dragons;

namespace DragonCLI.Eggs
{
    public class NenufarEgg : Egg
    {
        public NenufarEgg()
        {
            DragonName = "Nenufar Dragon Egg";
            Elements = ["Water", "Nature"];
            HatchingTime = DateTime.Now.AddHours(7);
            TargetDragon = (name) => new NenufarDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 1000;
            BreedingTime = TimeSpan.FromHours(5);
        }

    }
}
