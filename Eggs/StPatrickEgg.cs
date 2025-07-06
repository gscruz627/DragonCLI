using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class StPatrickEgg : Egg
    {
        public StPatrickEgg()
        {
            DragonName = "St Patrick Dragon Egg";
            Elements = ["Electric", "Nature"];
            HatchingTime = DateTime.Now.AddHours(15);
            TargetDragon = (name) => new StPatrickDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 5000;
            BreedingTime = TimeSpan.FromHours(9);
        }
    }
}