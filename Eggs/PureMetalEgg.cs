using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class PureMetalEgg : Egg
    {
        public PureMetalEgg()
        {
            DragonName = "Pure Metal Dragon Egg";
            Elements = ["Pure", "Metal"];
            HatchingTime = DateTime.Now.AddHours(52);
            TargetDragon = (name) => new PureMetalDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 384000;
            BreedingTime = TimeSpan.FromHours(44);
        }
    }
}