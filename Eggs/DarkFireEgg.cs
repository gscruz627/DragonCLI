using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class DarkFireEgg : Egg
    {
        public DarkFireEgg()
        {
            DragonName = "Dark Fire Dragon Egg";
            Elements = ["Dark", "Fire"];
            HatchingTime = DateTime.Now.AddHours(15);
            TargetDragon = (name) => new DarkFireDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 10000;
            BreedingTime = TimeSpan.FromHours(9);
        }
    }
}