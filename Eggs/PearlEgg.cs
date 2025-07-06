using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class PearlEgg : Egg
    {
        public PearlEgg()
        {
            DragonName = "Pearl Dragon Egg";
            Elements = ["Ice", "Metal"];
            HatchingTime = DateTime.Now.AddHours(19);
            TargetDragon = (name) => new PearlDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 5000;
            BreedingTime = TimeSpan.FromHours(13);
        }
    }
}