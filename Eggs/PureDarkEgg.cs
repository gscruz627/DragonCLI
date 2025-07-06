using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class PureDarkEgg : Egg
    {
        public PureDarkEgg()
        {
            DragonName = "Pure Dark Dragon Egg";
            Elements = ["Pure", "Dark"];
            HatchingTime = DateTime.Now.AddHours(52);
            TargetDragon = (name) => new PureDarkDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 384000;
            BreedingTime = TimeSpan.FromHours(44);
        }
    }
}