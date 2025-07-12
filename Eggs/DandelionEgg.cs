using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class DandelionEgg : Egg
    {
        public DandelionEgg()
        {
            DragonName = "Dandelion Dragon Egg";
            Elements = ["Nature", "Ice"];
            HatchingDuration = TimeSpan.FromHours(15);
TargetDragonClassName = "Dragons.DandelionDragon";
            Cost = Int32.MaxValue;
            HatchXP = 5000;
            BreedingTime = TimeSpan.FromHours(9);
        }
    }
}
