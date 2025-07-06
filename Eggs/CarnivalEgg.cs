using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class CarnivalEgg : Egg
    {
        public CarnivalEgg()
        {
            DragonName = "Carnival Dragon Egg";
            Elements = ["Metal", "Fire"];
            HatchingTime = DateTime.Now.AddHours(24);
            TargetDragon = (name) => new CarnivalDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 10000;
            BreedingTime = TimeSpan.FromHours(16);
        }
    }
}