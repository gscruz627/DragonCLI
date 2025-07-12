using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class MercuryEgg : Egg
    {
        public MercuryEgg()
        {
            DragonName = "Mercury Dragon Egg";
            Elements = ["Water", "Metal"];
            HatchingDuration = TimeSpan.FromHours(15);
TargetDragonClassName = "Dragons.MercuryDragon";
            Cost = Int32.MaxValue;
            HatchXP = 5000;
            BreedingTime = TimeSpan.FromHours(9);
        }
    }
}
