using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class HydraEgg : Egg
    {
        public HydraEgg()
        {
            DragonName = "Hydra Dragon Egg";
            Elements = ["Water", "Electric"];
            HatchingDuration = TimeSpan.FromHours(48);
TargetDragonClassName = "Dragons.HydraDragon";
            Cost = Int32.MaxValue;
            HatchXP = 250000;
            BreedingTime = TimeSpan.FromHours(40);
        }
    }
}
