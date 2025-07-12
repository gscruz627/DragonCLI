using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class PureNatureEgg : Egg
    {
        public PureNatureEgg()
        {
            DragonName = "Pure Nature Dragon Egg";
            Elements = ["Nature", "Pure"];
            HatchingDuration = TimeSpan.FromHours(52);
TargetDragonClassName = "Dragons.PureNatureDragon";
            Cost = Int32.MaxValue;
            HatchXP = 384000;
            BreedingTime = TimeSpan.FromHours(44);
        }
    }
}
