using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class GreatWhiteEgg : Egg
    {
        public GreatWhiteEgg()
        {
            DragonName = "Great White Dragon Egg";
            Elements = ["Ice", "Earth"];
            HatchingDuration = TimeSpan.FromHours(24);
TargetDragonClassName = "Dragons.GreatWhiteDragon";
            Cost = Int32.MaxValue;
            HatchXP = 50000;
            BreedingTime = TimeSpan.FromHours(16);
        }
    }
}
