using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class QuetzalEgg : Egg
    {
        public QuetzalEgg()
        {
            DragonName = "Quetzal Dragon Egg";
            Elements = ["Nature", "Fire"];
            HatchingTime = DateTime.Now.AddHours(24);
            TargetDragon = (name) => new QuetzalDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 50000;
            BreedingTime = TimeSpan.FromHours(16);
        }
    }
}