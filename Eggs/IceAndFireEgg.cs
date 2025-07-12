using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class IceAndFireEgg : Egg
    {
        public IceAndFireEgg()
        {
            DragonName = "Ice and Fire Dragon Egg";
            Elements = ["Ice", "Fire"];
            HatchingDuration = TimeSpan.FromHours(36);
TargetDragonClassName = "Dragons.IceAndFireDragon";
            Cost = Int32.MaxValue;
            HatchXP = 200000;
            BreedingTime = TimeSpan.FromHours(28);
        }
    }
}
