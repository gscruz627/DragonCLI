using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class PlanktonEgg : Egg
    {
        public PlanktonEgg()
        {
            DragonName = "Plankton Dragon Egg";
            Elements = ["Water", "Earth"];
            HatchingTime = DateTime.Now.AddHours(16);
            TargetDragon = (name) => new PlanktonDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 50000;
            BreedingTime = TimeSpan.FromHours(24);
        }
    }
}