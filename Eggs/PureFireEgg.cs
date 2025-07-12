using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class PureFireEgg : Egg
    {
        public PureFireEgg()
        {
            DragonName = "Pure Fire Dragon Egg";
            Elements = ["Pure", "Fire"];
            HatchingDuration = TimeSpan.FromHours(52);
TargetDragonClassName = "Dragons.PureFireDragon";
            Cost = Int32.MaxValue;
            HatchXP = 384000;
            BreedingTime = TimeSpan.FromHours(44);
        }
    }
}
