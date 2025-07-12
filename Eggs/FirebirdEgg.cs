using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DragonCLI.Dragons;

namespace DragonCLI.Eggs
{
    public class FirebirdEgg : Egg
    {
        public FirebirdEgg()
        {
            DragonName = "Firebird Dragon Egg";
            Elements = ["Nature", "Fire"];
            HatchingDuration = TimeSpan.FromHours(13);
TargetDragonClassName = "Dragons.FirebirdDragon";
            Cost = Int32.MaxValue;
            HatchXP = 1000;
            BreedingTime = TimeSpan.FromHours(7);
        }
    }
}
