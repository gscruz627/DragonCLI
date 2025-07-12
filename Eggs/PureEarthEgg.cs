using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class PureEarthEgg : Egg
    {
        public PureEarthEgg()
        {
            DragonName = "Pure Earth Dragon Egg";
            Elements = ["Pure", "Earth"];
            HatchingDuration = TimeSpan.FromHours(52);
TargetDragonClassName = "Dragons.PureEarthDragon";
            Cost = Int32.MaxValue;
            HatchXP = 384000;
            BreedingTime = TimeSpan.FromHours(44);
        }
    }
}
