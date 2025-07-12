using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class AuroraEgg : Egg
    {
        public AuroraEgg()
        {
            DragonName = "Aurora Dragon Egg";
            Elements = ["Electric", "Fire"];
            HatchingDuration = TimeSpan.FromHours(24);
TargetDragonClassName = "Dragons.AuroraDragon";
            Cost = Int32.MaxValue;
            HatchXP = 150000;
            BreedingTime = TimeSpan.FromHours(16);
        }
    }
}
