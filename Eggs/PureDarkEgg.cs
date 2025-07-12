using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class PureDarkEgg : Egg
    {
        public PureDarkEgg()
        {
            DragonName = "Pure Dark Dragon Egg";
            Elements = ["Pure", "Dark"];
            HatchingDuration = TimeSpan.FromHours(52);
TargetDragonClassName = "Dragons.PureDarkDragon";
            Cost = Int32.MaxValue;
            HatchXP = 384000;
            BreedingTime = TimeSpan.FromHours(44);
        }
    }
}
