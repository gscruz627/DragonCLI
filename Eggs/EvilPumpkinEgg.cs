using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class EvilPumpkinEgg : Egg
    {
        public EvilPumpkinEgg()
        {
            DragonName = "Evil Pumpkin Dragon Egg";
            Elements = ["Dark", "Nature"];
            HatchingDuration = TimeSpan.FromHours(9);
TargetDragonClassName = "Dragons.EvilPumpkinDragon";
            Cost = Int32.MaxValue;
            HatchXP = 5000;
            BreedingTime = TimeSpan.FromHours(6);
        }
    }
}
