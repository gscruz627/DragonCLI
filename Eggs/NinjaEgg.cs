using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class NinjaEgg : Egg
    {
        public NinjaEgg()
        {
            DragonName = "Ninja Dragon Egg";
            Elements = ["Nature", "Metal"];
            HatchingTime = DateTime.Now.AddHours(15);
            TargetDragon = (name) => new NinjaDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 30000;
            BreedingTime = TimeSpan.FromHours(9);
        }
    }
}
