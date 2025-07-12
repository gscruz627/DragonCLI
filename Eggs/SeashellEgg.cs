using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class SeashellEgg : Egg
    {
        public SeashellEgg()
        {
            DragonName = "Seashell Dragon Egg";
            Elements = ["Water", "Metal"];
            HatchingDuration = TimeSpan.FromHours(15);
TargetDragonClassName = "Dragons.SeashellDragon";
            Cost = Int32.MaxValue;
            HatchXP = 8000;
            BreedingTime = TimeSpan.FromHours(9);
        }
    }
}
