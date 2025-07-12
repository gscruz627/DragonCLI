using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class BatEgg : Egg
    {
        public BatEgg()
        {
            DragonName = "Bat Dragon Egg";
            Elements = ["Dark", "Earth"];
            HatchingDuration = TimeSpan.FromHours(24);
TargetDragonClassName = "Dragons.BatDragon";
            Cost = Int32.MaxValue;
            HatchXP = 100000;
            BreedingTime = TimeSpan.FromHours(16);
        }
    }
}
