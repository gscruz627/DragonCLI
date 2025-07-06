using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class CrystalEgg : Egg
    {
        public CrystalEgg()
        {
            DragonName = "Crystal Dragon Egg";
            Elements = ["Legendary"];
            HatchingTime = DateTime.Now.AddHours(58);
            TargetDragon = (name) => new CrystalDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 432000;
            BreedingTime = TimeSpan.FromHours(50);
        }
    }
}