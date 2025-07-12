using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class AlienEgg : Egg
    {
        public AlienEgg()
        {
            DragonName = "Alien Dragon Egg";
            Elements = ["Water", "Metal"];
            HatchingDuration = TimeSpan.FromHours(15);
TargetDragonClassName = "Dragons.AlienDragon";
            Cost = Int32.MaxValue;
            HatchXP = 30000;
            BreedingTime = TimeSpan.FromHours(8);
        }
    }
}
