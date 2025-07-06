using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class PureEgg : Egg
    {
        public PureEgg()
        {
            DragonName = "Pure Dragon Egg";
            Elements = ["Pure"];
            HatchingTime = DateTime.Now.AddHours(15);
            TargetDragon = (name) => new PureDragon(name);
            Cost = 700000;
            HatchXP = 336000;
            BreedingTime = TimeSpan.FromHours(9);
        }
    }
}