using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class JellyEgg : Egg
    {
        public JellyEgg()
        {
            DragonName = "Jelly Dragon Egg";
            Elements = ["Water", "Earth"];
            HatchingDuration = TimeSpan.FromHours(15);
TargetDragonClassName = "Dragons.JellyDragon";
            Cost = Int32.MaxValue;
            HatchXP = 30000;
            BreedingTime = TimeSpan.FromHours(9);
        }
    }
}
