using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class EvilPumpkinEgg : Egg
    {
        public EvilPumpkinEgg()
        {
            DragonName = "Evil Pumpkin Dragon Egg";
            Elements = ["Dark", "Nature"];
            HatchingTime = DateTime.Now.AddHours(9);
            TargetDragon = (name) => new EvilPumpkinDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 5000;
            BreedingTime = TimeSpan.FromHours(6);
        }
    }
}