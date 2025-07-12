using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class PureWaterEgg : Egg
    {
        public PureWaterEgg()
        {
            DragonName = "Pure Water Dragon Egg";
            Elements = ["Water", "Pure"];
            HatchingDuration = TimeSpan.FromHours(52);
TargetDragonClassName = "Dragons.PureWaterDragon";
            Cost = Int32.MaxValue;
            HatchXP = 384000;
            BreedingTime = TimeSpan.FromHours(44);
        }
    }
}
