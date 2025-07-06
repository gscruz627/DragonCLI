using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class GhostEgg : Egg
    {
        public GhostEgg()
        {
            DragonName = "Ghost Dragon Egg";
            Elements = ["Dark", "Earth"];
            HatchingTime = DateTime.Now.AddHours(24);
            TargetDragon = (name) => new GhostDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 100000;
            BreedingTime = TimeSpan.FromHours(16);
        }
    }
}
