using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class PureElectricEgg : Egg
    {
        public PureElectricEgg()
        {
            DragonName = "Pure Electric Dragon Egg";
            Elements = ["Pure", "Electric"];
            HatchingTime = DateTime.Now.AddHours(52);
            TargetDragon = (name) => new PureElectricDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 384000;
            BreedingTime = TimeSpan.FromHours(44);
        }
    }
}