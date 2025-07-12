using DragonCLI.Dragons;
using System.Xml.Linq;
namespace DragonCLI.Eggs
{
    public class IceCubeEgg : Egg
    {
        public IceCubeEgg()
        {
            DragonName = "Ice Cube Dragon Egg";
            Elements = ["Water", "Ice"];
            HatchingDuration = TimeSpan.FromHours(15);
TargetDragonClassName = "Dragons.IceCubeDragon";
            Cost = Int32.MaxValue;
            HatchXP = 5000;
            BreedingTime = TimeSpan.FromHours(9);
        }
    }
}
