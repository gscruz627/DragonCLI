using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class NinjaEgg : Egg
    {
        public NinjaEgg()
        {
            DragonName = "Ninja Dragon Egg";
            Elements = ["Nature", "Metal"];
            HatchingDuration = TimeSpan.FromHours(15);
TargetDragonClassName = "Dragons.NinjaDragon";
            Cost = Int32.MaxValue;
            HatchXP = 30000;
            BreedingTime = TimeSpan.FromHours(9);
        }
    }
}
