using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class SteampunkEgg : Egg
    {
        public SteampunkEgg()
        {
            DragonName = "Steampunk Dragon Egg";
            Elements = ["Metal", "Fire"];
            HatchingDuration = TimeSpan.FromHours(19);
TargetDragonClassName = "Dragons.SteampunkDragon";
            Cost = Int32.MaxValue;
            HatchXP = 10000;
            BreedingTime = TimeSpan.FromHours(15);
        }
    }
}
