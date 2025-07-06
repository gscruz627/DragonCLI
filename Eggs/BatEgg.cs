using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class BatEgg : Egg
    {
        public BatEgg()
        {
            DragonName = "Bat Dragon Egg";
            Elements = ["Dark", "Earth"];
            HatchingTime = DateTime.Now.AddHours(24);
            TargetDragon = (name) => new BatDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 100000;
            BreedingTime = TimeSpan.FromHours(16);
        }
    }
}