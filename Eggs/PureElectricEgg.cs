using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class PureElectricEgg : Egg
    {
        public PureElectricEgg()
        {
            DragonName = "Pure Electric Dragon Egg";
            Elements = ["Pure", "Electric"];
            HatchingDuration = TimeSpan.FromHours(52);
TargetDragonClassName = "Dragons.PureElectricDragon";
            Cost = Int32.MaxValue;
            HatchXP = 384000;
            BreedingTime = TimeSpan.FromHours(44);
        }
    }
}
