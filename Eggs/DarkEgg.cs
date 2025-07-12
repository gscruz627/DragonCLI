using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class DarkEgg : Egg
    {
        public DarkEgg()
        {
            DragonName = "Dark Dragon Egg";
            Elements = ["Dark"];
            HatchingDuration = TimeSpan.FromHours(2);
TargetDragonClassName = "Dragons.DarkDragon";
            Cost = 120000;
            HatchXP = 100000;
            BreedingTime = TimeSpan.FromHours(2);
        }
    }
}
