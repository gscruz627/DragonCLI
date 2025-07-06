using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class PureEarthEgg : Egg
    {
        public PureEarthEgg()
        {
            DragonName = "Pure Earth Dragon Egg";
            Elements = ["Pure", "Earth"];
            HatchingTime = DateTime.Now.AddHours(52);
            TargetDragon = (name) => new PureEarthDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 384000;
            BreedingTime = TimeSpan.FromHours(44);
        }
    }
}
