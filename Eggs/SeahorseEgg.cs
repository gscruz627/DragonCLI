using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class SeahorseEgg : Egg
    {
        public SeahorseEgg()
        {
            DragonName = "Seahorse Dragon Egg";
            Elements = ["Water", "Nature"];
            HatchingTime = DateTime.Now.AddHours(24);
            TargetDragon = (name) => new SeahorseDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 50000;
            BreedingTime = TimeSpan.FromHours(16);
        }
    }
}