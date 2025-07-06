using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class KingEgg : Egg
    {
        public KingEgg()
        {
            DragonName = "King Dragon Egg";
            Elements = ["Metal", "Fire"];
            HatchingTime = DateTime.Now.AddHours(24);
            TargetDragon = (name) => new KingDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 150000;
            BreedingTime = TimeSpan.FromHours(16);
        }
    }
}