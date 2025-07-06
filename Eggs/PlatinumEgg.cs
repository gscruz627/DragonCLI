using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class PlatinumEgg : Egg
    {
        public PlatinumEgg()
        {
            DragonName = "Platinum Dragon Egg";
            Elements = ["Ice", "Metal"];
            HatchingTime = DateTime.Now.AddHours(15);
            TargetDragon = (name) => new PlatinumDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 10000;
            BreedingTime = TimeSpan.FromHours(9);
        }
    }
}