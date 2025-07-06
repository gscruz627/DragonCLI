using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class AuroraEgg : Egg
    {
        public AuroraEgg()
        {
            DragonName = "Aurora Dragon Egg";
            Elements = ["Electric", "Fire"];
            HatchingTime = DateTime.Now.AddHours(24);
            TargetDragon = (name) => new AuroraDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 150000;
            BreedingTime = TimeSpan.FromHours(16);
        }
    }
}
