using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class MedievalEgg : Egg
    {
        public MedievalEgg()
        {
            DragonName = "Medieval Dragon Egg";
            Elements = ["Metal", "Fire"];
            HatchingTime = DateTime.Now.AddHours(15);
            TargetDragon = (name) => new MedievalDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 10000;
            BreedingTime = TimeSpan.FromHours(9);
        }
    }
}