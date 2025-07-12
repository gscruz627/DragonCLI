using DragonCLI.Dragons;

namespace DragonCLI.Eggs
{
    public class AlpineEgg : Egg
    {
        public AlpineEgg()
        {
            DragonName = "Alpine Dragon Egg";
            Elements = ["Ice", "Earth"];
            HatchingDuration = TimeSpan.FromHours(19);
TargetDragonClassName = "Dragons.AlpineDragon";
            Cost = Int32.MaxValue;
            HatchXP = 5000;
            BreedingTime = TimeSpan.FromHours(13);
        }
    }
}
