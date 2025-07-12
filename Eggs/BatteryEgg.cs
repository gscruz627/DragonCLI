using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class BatteryEgg : Egg
    {
        public BatteryEgg()
        {
            DragonName = "Battery Dragon Egg";
            Elements = ["Electric", "Gold"];
            HatchingDuration = TimeSpan.FromHours(19);
TargetDragonClassName = "Dragons.BatteryDragon";
            Cost = Int32.MaxValue;
            HatchXP = 10000;
            BreedingTime = TimeSpan.FromHours(13);
        }
    }
}
