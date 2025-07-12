using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class HedgehogEgg : Egg
    {
        public HedgehogEgg()
        {
            DragonName = "Hedgehog Dragon Egg";
            Elements = ["Earth", "Dark"];
            HatchingDuration = TimeSpan.FromHours(15);
TargetDragonClassName = "Dragons.HedgehogDragon";
            Cost = Int32.MaxValue;
            HatchXP = 100000;
            BreedingTime = TimeSpan.FromHours(9);
        }
    }
}
