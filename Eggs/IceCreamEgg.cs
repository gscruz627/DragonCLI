using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class IceCreamEgg : Egg
    {
        public IceCreamEgg()
        {
            DragonName = "Ice Cream Dragon Egg";
            Elements = ["Water", "Ice"];
            HatchingTime = DateTime.Now.AddHours(15);
            TargetDragon = (name) => new IceCreamDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 5000;
            BreedingTime = TimeSpan.FromHours(9);
        }
    }
}
