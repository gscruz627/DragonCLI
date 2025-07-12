using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class PureMetalEgg : Egg
    {
        public PureMetalEgg()
        {
            DragonName = "Pure Metal Dragon Egg";
            Elements = ["Pure", "Metal"];
            HatchingDuration = TimeSpan.FromHours(52);
TargetDragonClassName = "Dragons.PureMetalDragon";
            Cost = Int32.MaxValue;
            HatchXP = 384000;
            BreedingTime = TimeSpan.FromHours(44);
        }
    }
}
