using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class HydraEgg : Egg
    {
        public HydraEgg()
        {
            DragonName = "Hydra Dragon Egg";
            Elements = ["Water", "Electric"];
            HatchingTime = DateTime.Now.AddHours(48);
            TargetDragon = (name) => new HydraDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 250000;
            BreedingTime = TimeSpan.FromHours(40);
        }
    }
}