using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DragonCLI.Dragons;

namespace DragonCLI.Eggs
{
    public class GummyEgg : Egg
    {
        public GummyEgg()
        {
            DragonName = "Gummy Dragon Egg";
            Elements = ["Nature", "Electric"];
            HatchingTime = DateTime.Now.AddHours(13);
            TargetDragon = (name) => new GummyDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 5000;
            BreedingTime = TimeSpan.FromHours(7);
        }
    }
}
