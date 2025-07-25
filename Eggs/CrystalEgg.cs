using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class CrystalEgg : Egg
    {
        public CrystalEgg()
        {
            DragonName = "Crystal Dragon Egg";
            Elements = ["Legendary"];
            HatchingDuration = TimeSpan.FromHours(58);
TargetDragonClassName = "Dragons.CrystalDragon";
            Cost = Int32.MaxValue;
            HatchXP = 432000;
            BreedingTime = TimeSpan.FromHours(50);
        }
    }
}
