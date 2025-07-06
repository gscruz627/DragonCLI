using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class SeashellEgg : Egg
    {
        public SeashellEgg()
        {
            DragonName = "Seashell Dragon Egg";
            Elements = ["Water", "Metal"];
            HatchingTime = DateTime.Now.AddHours(15);
            TargetDragon = (name) => new SeashellDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 8000;
            BreedingTime = TimeSpan.FromHours(9);
        }
    }
}