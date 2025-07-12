using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class QueenEgg : Egg
    {
        public QueenEgg()
        {
            DragonName = "Queen Dragon Egg";
            Elements = ["Nature", "Metal"];
            HatchingDuration = TimeSpan.FromHours(24);
TargetDragonClassName = "Dragons.QueenDragon";
            Cost = Int32.MaxValue;
            HatchXP = 150000;
            BreedingTime = TimeSpan.FromHours(16);
        }
    }
}
