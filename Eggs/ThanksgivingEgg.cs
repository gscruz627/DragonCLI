using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class ThanksgivingEgg : Egg
    {
        public ThanksgivingEgg()
        {
            DragonName = "Thanksgiving Dragon Egg";
            Elements = ["Fire", "Water"];
            HatchingDuration = TimeSpan.FromHours(24);
TargetDragonClassName = "Dragons.ThanksgivingDragon";
            Cost = Int32.MaxValue;
            HatchXP = 100000;
            BreedingTime = TimeSpan.FromHours(16);
        }
    }
}
