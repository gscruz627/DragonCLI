using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class CoolFireEgg : Egg
    {
        public CoolFireEgg()
        {
            DragonName = "Cool Fire Dragon Egg";
            Elements = ["Ice", "Fire"];
            HatchingTime = DateTime.Now.AddHours(15);
            TargetDragon = (name) => new CoolFireDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 5000;
            BreedingTime = TimeSpan.FromHours(9);
        }
    }
}