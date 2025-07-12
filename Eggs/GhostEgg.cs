using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class GhostEgg : Egg
    {
        public GhostEgg()
        {
            DragonName = "Ghost Dragon Egg";
            Elements = ["Dark", "Earth"];
            HatchingDuration = TimeSpan.FromHours(24);
TargetDragonClassName = "Dragons.GhostDragon";
            Cost = Int32.MaxValue;
            HatchXP = 100000;
            BreedingTime = TimeSpan.FromHours(16);
        }
    }
}
