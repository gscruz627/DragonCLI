using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class MedievalEgg : Egg
    {
        public MedievalEgg()
        {
            DragonName = "Medieval Dragon Egg";
            Elements = ["Metal", "Fire"];
            HatchingDuration = TimeSpan.FromHours(15);
TargetDragonClassName = "Dragons.MedievalDragon";
            Cost = Int32.MaxValue;
            HatchXP = 10000;
            BreedingTime = TimeSpan.FromHours(9);
        }
    }
}
