using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class CoolFireEgg : Egg
    {
        public CoolFireEgg()
        {
            DragonName = "Cool Fire Dragon Egg";
            Elements = ["Ice", "Fire"];
            HatchingDuration = TimeSpan.FromHours(15);
TargetDragonClassName = "Dragons.CoolFireDragon";
            Cost = Int32.MaxValue;
            HatchXP = 5000;
            BreedingTime = TimeSpan.FromHours(9);
        }
    }
}
