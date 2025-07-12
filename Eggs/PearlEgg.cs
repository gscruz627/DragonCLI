using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class PearlEgg : Egg
    {
        public PearlEgg()
        {
            DragonName = "Pearl Dragon Egg";
            Elements = ["Ice", "Metal"];
            HatchingDuration = TimeSpan.FromHours(19);
TargetDragonClassName = "Dragons.PearlDragon";
            Cost = Int32.MaxValue;
            HatchXP = 5000;
            BreedingTime = TimeSpan.FromHours(13);
        }
    }
}
