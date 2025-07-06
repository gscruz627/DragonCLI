using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class AztecEgg : Egg
    {
        public AztecEgg()
        {
            DragonName = "Aztec Dragon Egg";
            Elements = ["Earth", "Fire"];
            HatchingTime = DateTime.Now.AddHours(2);
            TargetDragon = (name) => new AztecDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 1500;
            BreedingTime = TimeSpan.FromHours(16);
        }
    }
}