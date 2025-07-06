using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class DarkEgg : Egg
    {
        public DarkEgg()
        {
            DragonName = "Dark Dragon Egg";
            Elements = ["Dark"];
            HatchingTime = DateTime.Now.AddHours(2);
            TargetDragon = (name) => new DarkDragon(name);
            Cost = 120000;
            HatchXP = 100000;
            BreedingTime = TimeSpan.FromHours(2);
        }
    }
}
