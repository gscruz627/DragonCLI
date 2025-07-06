using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class MusicEgg : Egg
    {
        public MusicEgg()
        {
            DragonName = "Music Dragon Egg";
            Elements = ["Electric", "Fire"];
            HatchingTime = DateTime.Now.AddHours(24);
            TargetDragon = (name) => new MusicDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 100000;
            BreedingTime = TimeSpan.FromHours(16);
        }
    }
}