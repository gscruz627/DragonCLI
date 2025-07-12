using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class SantaEgg : Egg
    {
        public SantaEgg()
        {
            DragonName = "Santa Dragon Egg";
            Elements = ["Ice", "Earth"];
            HatchingDuration = TimeSpan.FromHours(15);
TargetDragonClassName = "Dragons.SantaDragon";
            Cost = Int32.MaxValue;
            HatchXP = 30000;
            BreedingTime = TimeSpan.FromHours(8);
        }
    }
}
