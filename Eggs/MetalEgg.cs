using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class MetalEgg : Egg
    {
        public MetalEgg()
        {
            DragonName = "Metal Dragon Egg";
            Elements = ["Metal"];
            HatchingDuration = TimeSpan.FromHours(13);
TargetDragonClassName = "Dragons.MetalDragon";
            Cost = 60000;
            HatchXP = 10000;
            BreedingTime = TimeSpan.FromHours(7);
        }
    }
}
