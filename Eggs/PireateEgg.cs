using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class PirateEgg : Egg
    {
        public PirateEgg()
        {
            DragonName = "Pirate Dragon Egg";
            Elements = ["Water", "Dark"];
            HatchingTime = DateTime.Now.AddHours(18);
            TargetDragon = (name) => new PirateDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 200000;
            BreedingTime = TimeSpan.FromHours(12);
        }
    }
}