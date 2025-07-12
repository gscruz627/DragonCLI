using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class NeonEgg : Egg
    {
        public NeonEgg()
        {
            DragonName = "Neon Dragon Egg";
            Elements = ["Electric", "Dark"];
            HatchingDuration = TimeSpan.FromHours(15);
TargetDragonClassName = "Dragons.NeonDragon";
            Cost = Int32.MaxValue;
            HatchXP = 100000;
            BreedingTime = TimeSpan.FromHours(9);
        }
    }
}
