using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class PetroleumEgg : Egg
    {
        public PetroleumEgg()
        {
            DragonName = "Petroleum Dragon Egg";
            Elements = ["Water", "Dark"];
            HatchingTime = DateTime.Now.AddHours(19);
            TargetDragon = (name) => new PetroleumDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 200000;
            BreedingTime = TimeSpan.FromHours(13);
        }
    }
}