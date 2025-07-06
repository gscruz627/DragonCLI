using DragonCLI.Dragons;

namespace DragonCLI.Eggs
{
    public class LaserEgg : Egg
    {
        public LaserEgg()
        {
            DragonName = "Laser Dragon Egg";
            Elements = ["Electric", "Fire"];
            HatchingTime = DateTime.Now.AddHours(15);
            TargetDragon = (name) => new LaserDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 5000;
            BreedingTime = TimeSpan.FromHours(9);
        }
    }
}
