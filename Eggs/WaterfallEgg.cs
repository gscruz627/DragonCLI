using DragonCLI.Dragons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DragonCLI.Dragons;

namespace DragonCLI.Eggs
{
    public class WaterfallEgg : Egg
    {
        public WaterfallEgg()
        {
            DragonName = "Waterfall Dragon Egg";
            Elements = ["Earth", "Water"];
            HatchingTime = DateTime.Now.AddHours(4);
            TargetDragon = (name) => new WaterfallDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 100;
            BreedingTime = TimeSpan.FromHours(4);
        }
    }
}
