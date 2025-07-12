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
            HatchingDuration = TimeSpan.FromHours(7);
TargetDragonClassName = "Dragons.NenufarDragon";
            Cost = Int32.MaxValue;
            HatchXP = 1000;
            BreedingTime = TimeSpan.FromHours(5);
        }

    }
}
