using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class PlatinumEgg : Egg
    {
        public PlatinumEgg()
        {
            DragonName = "Platinum Dragon Egg";
            Elements = ["Ice", "Metal"];
            HatchingDuration = TimeSpan.FromHours(15);
TargetDragonClassName = "Dragons.PlatinumDragon";
            Cost = Int32.MaxValue;
            HatchXP = 10000;
            BreedingTime = TimeSpan.FromHours(9);
        }
    }
}
