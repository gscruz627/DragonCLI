using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class PlanktonEgg : Egg
    {
        public PlanktonEgg()
        {
            DragonName = "Plankton Dragon Egg";
            Elements = ["Water", "Earth"];
            HatchingDuration = TimeSpan.FromHours(16);
TargetDragonClassName = "Dragons.PlanktonDragon";
            Cost = Int32.MaxValue;
            HatchXP = 50000;
            BreedingTime = TimeSpan.FromHours(24);
        }
    }
}
