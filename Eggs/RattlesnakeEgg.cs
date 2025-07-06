using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class RattlesnakeEgg : Egg
    {
        public RattlesnakeEgg()
        {
            DragonName = "Rattlesnake Dragon Egg";
            Elements = ["Dark", "Nature"];
            HatchingTime = DateTime.Now.AddHours(15);
            TargetDragon = (name) => new RattlesnakeDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 100000;
            BreedingTime = TimeSpan.FromHours(9);
        }
    }
}