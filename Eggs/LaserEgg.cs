using DragonCLI.Dragons;

namespace DragonCLI.Eggs
{
    public class LaserEgg : Egg
    {
        public LaserEgg()
        {
            DragonName = "Laser Dragon Egg";
            Elements = ["Electric", "Fire"];
            HatchingDuration = TimeSpan.FromHours(15);
TargetDragonClassName = "Dragons.LaserDragon";
            Cost = Int32.MaxValue;
            HatchXP = 5000;
            BreedingTime = TimeSpan.FromHours(9);
        }
    }
}
