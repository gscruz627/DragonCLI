using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class IceCreamEgg : Egg
    {
        public IceCreamEgg()
        {
            DragonName = "Ice Cream Dragon Egg";
            Elements = ["Water", "Ice"];
            HatchingDuration = TimeSpan.FromHours(15);
TargetDragonClassName = "Dragons.IceCreamDragon";
            Cost = Int32.MaxValue;
            HatchXP = 5000;
            BreedingTime = TimeSpan.FromHours(9);
        }
    }
}
