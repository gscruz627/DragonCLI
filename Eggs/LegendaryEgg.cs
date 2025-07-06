using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class LegendaryEgg : Egg
    {
        public LegendaryEgg()
        {
            DragonName = "Legendary Dragon Egg";
            Elements = ["Legendary"];
            HatchingTime = DateTime.Now.AddHours(58);
            TargetDragon = (name) => new LegendaryDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 432000;
            BreedingTime = TimeSpan.FromHours(50);
        }
    }
}