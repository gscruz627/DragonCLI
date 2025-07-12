using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class PureIceEgg : Egg
    {
        public PureIceEgg()
        {
            DragonName = "Pure Ice Dragon Egg";
            Elements = ["Pure", "Ice"];
            HatchingDuration = TimeSpan.FromHours(52);
TargetDragonClassName = "Dragons.PureIceDragon";
            Cost = Int32.MaxValue;
            HatchXP = 384000;
            BreedingTime = TimeSpan.FromHours(44);
        }
    }
}
