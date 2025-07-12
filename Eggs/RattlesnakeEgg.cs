using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class RattlesnakeEgg : Egg
    {
        public RattlesnakeEgg()
        {
            DragonName = "Rattlesnake Dragon Egg";
            Elements = ["Dark", "Nature"];
            HatchingDuration = TimeSpan.FromHours(15);
TargetDragonClassName = "Dragons.RattlesnakeDragon";
            Cost = Int32.MaxValue;
            HatchXP = 100000;
            BreedingTime = TimeSpan.FromHours(9);
        }
    }
}
