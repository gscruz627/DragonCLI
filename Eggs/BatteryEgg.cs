using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class BatteryEgg : Egg
    {
        public BatteryEgg()
        {
            DragonName = "Battery Dragon Egg";
            Elements = ["Electric", "Gold"];
            HatchingTime = DateTime.Now.AddHours(19);
            TargetDragon = (name) => new BatteryDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 10000;
            BreedingTime = TimeSpan.FromHours(13);
        }
    }
}
