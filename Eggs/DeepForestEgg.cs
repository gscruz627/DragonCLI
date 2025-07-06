using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class DeepForestEgg : Egg
    {
        public DeepForestEgg()
        {
            DragonName = "Deep Forest Dragon Egg";
            Elements = ["Earth", "Nature"];
            HatchingTime = DateTime.Now.AddHours(24);
            TargetDragon = (name) => new DeepForestDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 100000;
            BreedingTime = TimeSpan.FromHours(16);
        }
    }
}