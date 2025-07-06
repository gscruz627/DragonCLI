using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class DandelionEgg : Egg
    {
        public DandelionEgg()
        {
            DragonName = "Dandelion Dragon Egg";
            Elements = ["Nature", "Ice"];
            HatchingTime = DateTime.Now.AddHours(15);
            TargetDragon = (name) => new DandelionDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 5000;
            BreedingTime = TimeSpan.FromHours(9);
        }
    }
}