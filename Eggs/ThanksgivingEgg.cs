using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class ThanksgivingEgg : Egg
    {
        public ThanksgivingEgg()
        {
            DragonName = "Thanksgiving Dragon Egg";
            Elements = ["Fire", "Water"];
            HatchingTime = DateTime.Now.AddHours(24);
            TargetDragon = (name) => new ThanksgivingDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 100000;
            BreedingTime = TimeSpan.FromHours(16);
        }
    }
}