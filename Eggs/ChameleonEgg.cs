using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DragonCLI.Dragons;

namespace DragonCLI.Eggs
{
    public class ChameleonEgg : Egg
    {
        public ChameleonEgg()
        {
            DragonName = "Chameleon Dragon Egg";
            Elements = ["Earth", "Electric"];
            HatchingDuration = TimeSpan.FromHours(15);
TargetDragonClassName = "Dragons.ChameleonDragon";
            Cost = Int32.MaxValue;
            HatchXP = 5000;
            BreedingTime = TimeSpan.FromHours(9);
        }
    }
}
