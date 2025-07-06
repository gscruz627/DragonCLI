using DragonCLI.Dragons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class SpicyEgg : Egg
    {
        public SpicyEgg()
        {
            DragonName = "Spicy Dragon Egg";
            Elements = ["Nature", "Fire"];
            HatchingTime = DateTime.Now.AddHours(13);
            TargetDragon = (name) => new SpicyDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 5000;
            BreedingTime = TimeSpan.FromHours(7);
        }
    }
}
