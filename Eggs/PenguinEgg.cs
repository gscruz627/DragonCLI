using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class PenguinEgg : Egg
    {
        public PenguinEgg()
        {
            DragonName = "Penguin Dragon Egg";
            Elements = ["Dark", "Ice"];
            HatchingTime = DateTime.Now.AddHours(18);
            TargetDragon = (name) => new PenguinDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 100000;
            BreedingTime = TimeSpan.FromHours(12);
        }
    }
}