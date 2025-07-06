using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class NeonEgg : Egg
    {
        public NeonEgg()
        {
            DragonName = "Neon Dragon Egg";
            Elements = ["Electric", "Dark"];
            HatchingTime = DateTime.Now.AddHours(15);
            TargetDragon = (name) => new NeonDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 100000;
            BreedingTime = TimeSpan.FromHours(9);
        }
    }
}
