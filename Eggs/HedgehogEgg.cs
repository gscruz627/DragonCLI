using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class HedgehogEgg : Egg
    {
        public HedgehogEgg()
        {
            DragonName = "Hedgehog Dragon Egg";
            Elements = ["Earth", "Dark"];
            HatchingTime = DateTime.Now.AddHours(15);
            TargetDragon = (name) => new HedgehogDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 100000;
            BreedingTime = TimeSpan.FromHours(9);
        }
    }
}