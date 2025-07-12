using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class MusicEgg : Egg
    {
        public MusicEgg()
        {
            DragonName = "Music Dragon Egg";
            Elements = ["Electric", "Fire"];
            HatchingDuration = TimeSpan.FromHours(24);
TargetDragonClassName = "Dragons.MusicDragon";
            Cost = Int32.MaxValue;
            HatchXP = 100000;
            BreedingTime = TimeSpan.FromHours(16);
        }
    }
}
