using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class DeepForestEgg : Egg
    {
        public DeepForestEgg()
        {
            DragonName = "Deep Forest Dragon Egg";
            Elements = ["Earth", "Nature"];
            HatchingDuration = TimeSpan.FromHours(24);
TargetDragonClassName = "Dragons.DeepForestDragon";
            Cost = Int32.MaxValue;
            HatchXP = 100000;
            BreedingTime = TimeSpan.FromHours(16);
        }
    }
}
