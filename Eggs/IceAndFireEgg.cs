using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class IceAndFireEgg : Egg
    {
        public IceAndFireEgg()
        {
            DragonName = "Ice and Fire Dragon Egg";
            Elements = ["Ice", "Fire"];
            HatchingTime = DateTime.Now.AddHours(36);
            TargetDragon = (name) => new IceAndFireDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 200000;
            BreedingTime = TimeSpan.FromHours(28);
        }
    }
}