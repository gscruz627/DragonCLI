using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class CarnivalEgg : Egg
    {
        public CarnivalEgg()
        {
            DragonName = "Carnival Dragon Egg";
            Elements = ["Metal", "Fire"];
            HatchingDuration = TimeSpan.FromHours(24);
TargetDragonClassName = "Dragons.CarnivalDragon";
            Cost = Int32.MaxValue;
            HatchXP = 10000;
            BreedingTime = TimeSpan.FromHours(16);
        }
    }
}
