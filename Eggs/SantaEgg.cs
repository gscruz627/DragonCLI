using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class SantaEgg : Egg
    {
        public SantaEgg()
        {
            DragonName = "Santa Dragon Egg";
            Elements = ["Ice", "Earth"];
            HatchingTime = DateTime.Now.AddHours(15);
            TargetDragon = (name) => new SantaDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 30000;
            BreedingTime = TimeSpan.FromHours(8);
        }
    }
}