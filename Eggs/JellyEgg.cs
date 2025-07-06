using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class JellyEgg : Egg
    {
        public JellyEgg()
        {
            DragonName = "Jelly Dragon Egg";
            Elements = ["Water", "Earth"];
            HatchingTime = DateTime.Now.AddHours(15);
            TargetDragon = (name) => new JellyDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 30000;
            BreedingTime = TimeSpan.FromHours(9);
        }
    }
}