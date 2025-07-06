using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class ZombieEgg : Egg
    {
        public ZombieEgg()
        {
            DragonName = "Zombie Dragon Egg";
            Elements = ["Metal", "Dark"];
            HatchingTime = DateTime.Now.AddHours(15);
            TargetDragon = (name) => new ZombieDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 100000;
            BreedingTime = TimeSpan.FromHours(9);
        }
    }
}