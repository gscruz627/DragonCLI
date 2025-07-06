using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class AirEgg : Egg
    {
        public AirEgg()
        {
            DragonName = "Air Dragon Egg";
            Elements = ["Legendary"];
            HatchingTime = DateTime.Now.AddHours(58);
            TargetDragon = (name) => new AirDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 432000;
            BreedingTime = TimeSpan.FromHours(50);
        }
    }
}