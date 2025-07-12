using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class SoccerEgg : Egg
    {
        public SoccerEgg()
        {
            DragonName = "Soccer Dragon Egg";
            Elements = ["Ice", "Fire"];
            HatchingDuration = TimeSpan.FromHours(15);
TargetDragonClassName = "Dragons.SoccerDragon";
            Cost = Int32.MaxValue;
            HatchXP = 5000;
            BreedingTime = TimeSpan.FromHours(9);
        }
    }
}
