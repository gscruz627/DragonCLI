using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class DragonflyEgg : Egg
    {
        public DragonflyEgg()
        {
            DragonName = "DragonFly Dragon Egg";
            Elements = ["Nature", "Metal"];
            HatchingDuration = TimeSpan.FromHours(19);
TargetDragonClassName = "Dragons.DragonflyDragon";
            Cost = Int32.MaxValue;
            HatchXP = 5000;
            BreedingTime = TimeSpan.FromHours(13);
        }
    }
}
