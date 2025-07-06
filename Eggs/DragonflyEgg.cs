using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class DragonflyEgg : Egg
    {
        public DragonflyEgg()
        {
            DragonName = "DragonFly Dragon Egg";
            Elements = ["Nature", "Metal"];
            HatchingTime = DateTime.Now.AddHours(19);
            TargetDragon = (name) => new DragonflyDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 5000;
            BreedingTime = TimeSpan.FromHours(13);
        }
    }
}