using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class KingEgg : Egg
    {
        public KingEgg()
        {
            DragonName = "King Dragon Egg";
            Elements = ["Metal", "Fire"];
            HatchingDuration = TimeSpan.FromHours(24);
TargetDragonClassName = "Dragons.KingDragon";
            Cost = Int32.MaxValue;
            HatchXP = 150000;
            BreedingTime = TimeSpan.FromHours(16);
        }
    }
}
