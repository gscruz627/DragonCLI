using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class AirEgg : Egg
    {
        public AirEgg()
        {
            DragonName = "Air Dragon Egg";
            Elements = ["Legendary"];
            HatchingDuration = TimeSpan.FromHours(58);
TargetDragonClassName = "Dragons.AirDragon";
            Cost = Int32.MaxValue;
            HatchXP = 432000;
            BreedingTime = TimeSpan.FromHours(50);
        }
    }
}
