using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class GoldEgg : Egg
    {
        public GoldEgg()
        {
            DragonName = "Gold Dragon Egg";
            Elements = ["Electric", "Metal"];
            HatchingTime = DateTime.Now.AddHours(15);
            TargetDragon = (name) => new GoldDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 10000;
            BreedingTime = TimeSpan.FromHours(9);
        }
    }
}