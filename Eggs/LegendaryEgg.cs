using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class LegendaryEgg : Egg
    {
        public LegendaryEgg()
        {
            DragonName = "Legendary Dragon Egg";
            Elements = ["Legendary"];
            HatchingDuration = TimeSpan.FromHours(58);
TargetDragonClassName = "Dragons.LegendaryDragon";
            Cost = Int32.MaxValue;
            HatchXP = 432000;
            BreedingTime = TimeSpan.FromHours(50);
        }
    }
}
