using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class SteampunkEgg : Egg
    {
        public SteampunkEgg()
        {
            DragonName = "Steampunk Dragon Egg";
            Elements = ["Metal", "Fire"];
            HatchingTime = DateTime.Now.AddHours(19);
            TargetDragon = (name) => new SteampunkDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 10000;
            BreedingTime = TimeSpan.FromHours(15);
        }
    }
}