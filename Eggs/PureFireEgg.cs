using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class PureFireEgg : Egg
    {
        public PureFireEgg()
        {
            DragonName = "Pure Fire Dragon Egg";
            Elements = ["Pure", "Fire"];
            HatchingTime = DateTime.Now.AddHours(52);
            TargetDragon = (name) => new PureFireDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 384000;
            BreedingTime = TimeSpan.FromHours(44);
        }
    }
}