using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class QuetzalEgg : Egg
    {
        public QuetzalEgg()
        {
            DragonName = "Quetzal Dragon Egg";
            Elements = ["Nature", "Fire"];
            HatchingDuration = TimeSpan.FromHours(24);
TargetDragonClassName = "Dragons.QuetzalDragon";
            Cost = Int32.MaxValue;
            HatchXP = 50000;
            BreedingTime = TimeSpan.FromHours(16);
        }
    }
}
