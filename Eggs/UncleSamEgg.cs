using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class UncleSamEgg : Egg
    {
        public UncleSamEgg()
        {
            DragonName = "Uncle Sam Dragon Egg";
            Elements = ["Electric", "Metal"];
            HatchingDuration = TimeSpan.FromHours(15);
TargetDragonClassName = "Dragons.UncleSamDragon";
            Cost = Int32.MaxValue;
            HatchXP = 30000;
            BreedingTime = TimeSpan.FromHours(9);
        }
    }
}
