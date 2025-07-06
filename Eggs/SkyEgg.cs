using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class SkyEgg : Egg
    {
        public SkyEgg()
        {
            DragonName = "Sky Dragon Egg";
            Elements = ["Electric", "Earth"];
            HatchingTime = DateTime.Now.AddHours(24);
            TargetDragon = (name) => new SkyDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 50000;
            BreedingTime = TimeSpan.FromHours(16);
        }
    }
}