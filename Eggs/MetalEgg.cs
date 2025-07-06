using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class MetalEgg : Egg
    {
        public MetalEgg()
        {
            DragonName = "Metal Dragon Egg";
            Elements = ["Metal"];
            HatchingTime = DateTime.Now.AddHours(13);
            TargetDragon = (name) => new MetalDragon(name);
            Cost = 60000;
            HatchXP = 10000;
            BreedingTime = TimeSpan.FromHours(7);
        }
    }
}