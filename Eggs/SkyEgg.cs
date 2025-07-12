using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class SkyEgg : Egg
    {
        public SkyEgg()
        {
            DragonName = "Sky Dragon Egg";
            Elements = ["Electric", "Earth"];
            HatchingDuration = TimeSpan.FromHours(24);
TargetDragonClassName = "Dragons.SkyDragon";
            Cost = Int32.MaxValue;
            HatchXP = 50000;
            BreedingTime = TimeSpan.FromHours(16);
        }
    }
}
