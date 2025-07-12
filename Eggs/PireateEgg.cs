using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class PirateEgg : Egg
    {
        public PirateEgg()
        {
            DragonName = "Pirate Dragon Egg";
            Elements = ["Water", "Dark"];
            HatchingDuration = TimeSpan.FromHours(18);
TargetDragonClassName = "Dragons.PirateDragon";
            Cost = Int32.MaxValue;
            HatchXP = 200000;
            BreedingTime = TimeSpan.FromHours(12);
        }
    }
}
