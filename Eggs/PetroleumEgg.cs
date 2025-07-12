using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class PetroleumEgg : Egg
    {
        public PetroleumEgg()
        {
            DragonName = "Petroleum Dragon Egg";
            Elements = ["Water", "Dark"];
            HatchingDuration = TimeSpan.FromHours(19);
TargetDragonClassName = "Dragons.PetroleumDragon";
            Cost = Int32.MaxValue;
            HatchXP = 200000;
            BreedingTime = TimeSpan.FromHours(13);
        }
    }
}
