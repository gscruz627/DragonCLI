using DragonCLI.Dragons;

namespace DragonCLI.Eggs
{
    public class StarEgg : Egg
    {
        public StarEgg()
        {
            DragonName = "Star Dragon Egg";
            Elements = ["Earth", "Electric"];
            HatchingDuration = TimeSpan.FromHours(9);
TargetDragonClassName = "Dragons.StarDragon";
            Cost = Int32.MaxValue;
            HatchXP = 5000;
            BreedingTime = TimeSpan.FromHours(7);
        }
    }
}
