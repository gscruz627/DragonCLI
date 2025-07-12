using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class ChineseEgg : Egg
    {
        public ChineseEgg()
        {
            DragonName = "Chinese Dragon Egg";
            Elements = ["Earth", "Fire"];
            HatchingDuration = TimeSpan.FromHours(15);
TargetDragonClassName = "Dragons.ChineseDragon";
            Cost = Int32.MaxValue;
            HatchXP = 30000;
            BreedingTime = TimeSpan.FromHours(9);
        }
    }
}
