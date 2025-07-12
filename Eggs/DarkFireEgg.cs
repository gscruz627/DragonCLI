using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class DarkFireEgg : Egg
    {
        public DarkFireEgg()
        {
            DragonName = "Dark Fire Dragon Egg";
            Elements = ["Dark", "Fire"];
            HatchingDuration = TimeSpan.FromHours(15);
TargetDragonClassName = "Dragons.DarkFireDragon";
            Cost = Int32.MaxValue;
            HatchXP = 10000;
            BreedingTime = TimeSpan.FromHours(9);
        }
    }
}
