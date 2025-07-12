using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class ZombieEgg : Egg
    {
        public ZombieEgg()
        {
            DragonName = "Zombie Dragon Egg";
            Elements = ["Metal", "Dark"];
            HatchingDuration = TimeSpan.FromHours(15);
TargetDragonClassName = "Dragons.ZombieDragon";
            Cost = Int32.MaxValue;
            HatchXP = 100000;
            BreedingTime = TimeSpan.FromHours(9);
        }
    }
}
