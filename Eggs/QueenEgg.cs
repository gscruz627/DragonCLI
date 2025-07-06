using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class QueenEgg : Egg
    {
        public QueenEgg()
        {
            DragonName = "Queen Dragon Egg";
            Elements = ["Nature", "Metal"];
            HatchingTime = DateTime.Now.AddHours(24);
            TargetDragon = (name) => new QueenDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 150000;
            BreedingTime = TimeSpan.FromHours(16);
        }
    }
}