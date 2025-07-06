using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class AlienEgg : Egg
    {
        public AlienEgg()
        {
            DragonName = "Alien Dragon Egg";
            Elements = ["Water", "Metal"];
            HatchingTime = DateTime.Now.AddHours(15);
            TargetDragon = (name) => new AlienDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 30000;
            BreedingTime = TimeSpan.FromHours(8);
        }
    }
}