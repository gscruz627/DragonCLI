using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class MercuryEgg : Egg
    {
        public MercuryEgg()
        {
            DragonName = "Mercury Dragon Egg";
            Elements = ["Water", "Metal"];
            HatchingTime = DateTime.Now.AddHours(15);
            TargetDragon = (name) => new MercuryDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 5000;
            BreedingTime = TimeSpan.FromHours(9);
        }
    }
}