using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class GoldEgg : Egg
    {
        public GoldEgg()
        {
            DragonName = "Gold Dragon Egg";
            Elements = ["Electric", "Metal"];
            HatchingDuration = TimeSpan.FromHours(15);
TargetDragonClassName = "Dragons.GoldDragon";
            Cost = Int32.MaxValue;
            HatchXP = 10000;
            BreedingTime = TimeSpan.FromHours(9);
        }
    }
}
