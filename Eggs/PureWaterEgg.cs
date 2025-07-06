using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class PureWaterEgg : Egg
    {
        public PureWaterEgg()
        {
            DragonName = "Pure Water Dragon Egg";
            Elements = ["Water", "Pure"];
            HatchingTime = DateTime.Now.AddHours(52);
            TargetDragon = (name) => new PureWaterDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 384000;
            BreedingTime = TimeSpan.FromHours(44);
        }
    }
}