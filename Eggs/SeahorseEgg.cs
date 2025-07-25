using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class SeahorseEgg : Egg
    {
        public SeahorseEgg()
        {
            DragonName = "Seahorse Dragon Egg";
            Elements = ["Water", "Nature"];
            HatchingDuration = TimeSpan.FromHours(24);
TargetDragonClassName = "Dragons.SeahorseDragon";
            Cost = Int32.MaxValue;
            HatchXP = 50000;
            BreedingTime = TimeSpan.FromHours(16);
        }
    }
}
