using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DragonCLI.Dragons;

namespace DragonCLI.Eggs
{
    public class MudEgg : Egg
    {
        public MudEgg()
        {
            DragonName = "Mud Dragon Egg";
            Elements = ["Earth", "Water"];
            HatchingTime = DateTime.Now.AddHours(7);
            TargetDragon = (name) => new MudDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 250;
            BreedingTime = TimeSpan.FromHours(5);
        }
    }
}
