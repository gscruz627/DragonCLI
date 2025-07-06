using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class SoccerEgg : Egg
    {
        public SoccerEgg()
        {
            DragonName = "Soccer Dragon Egg";
            Elements = ["Ice", "Fire"];
            HatchingTime = DateTime.Now.AddHours(15);
            TargetDragon = (name) => new SoccerDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 5000;
            BreedingTime = TimeSpan.FromHours(9);
        }
    }
}