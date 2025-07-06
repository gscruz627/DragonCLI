using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class GreatWhiteEgg : Egg
    {
        public GreatWhiteEgg()
        {
            DragonName = "Great White Dragon Egg";
            Elements = ["Ice", "Earth"];
            HatchingTime = DateTime.Now.AddHours(24);
            TargetDragon = (name) => new GreatWhiteDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 50000;
            BreedingTime = TimeSpan.FromHours(16);
        }
    }
}