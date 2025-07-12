using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class StPatrickEgg : Egg
    {
        public StPatrickEgg()
        {
            DragonName = "St Patrick Dragon Egg";
            Elements = ["Electric", "Nature"];
            HatchingDuration = TimeSpan.FromHours(15);
TargetDragonClassName = "Dragons.StPatrickDragon";
            Cost = Int32.MaxValue;
            HatchXP = 5000;
            BreedingTime = TimeSpan.FromHours(9);
        }
    }
}
