using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class AztecEgg : Egg
    {
        public AztecEgg()
        {
            DragonName = "Aztec Dragon Egg";
            Elements = ["Earth", "Fire"];
            HatchingDuration = TimeSpan.FromHours(2);
TargetDragonClassName = "Dragons.AztecDragon";
            Cost = Int32.MaxValue;
            HatchXP = 1500;
            BreedingTime = TimeSpan.FromHours(16);
        }
    }
}
