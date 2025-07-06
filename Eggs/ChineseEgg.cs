using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class ChineseEgg : Egg
    {
        public ChineseEgg()
        {
            DragonName = "Chinese Dragon Egg";
            Elements = ["Earth", "Fire"];
            HatchingTime = DateTime.Now.AddHours(15);
            TargetDragon = (name) => new ChineseDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 30000;
            BreedingTime = TimeSpan.FromHours(9);
        }
    }
}