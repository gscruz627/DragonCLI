using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class PureEgg : Egg
    {
        public PureEgg()
        {
            DragonName = "Pure Dragon Egg";
            Elements = ["Pure"];
            HatchingDuration = TimeSpan.FromHours(15);
TargetDragonClassName = "Dragons.PureDragon";
            Cost = 700000;
            HatchXP = 336000;
            BreedingTime = TimeSpan.FromHours(9);
        }
    }
}
