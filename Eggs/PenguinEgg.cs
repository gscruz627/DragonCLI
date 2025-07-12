using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class PenguinEgg : Egg
    {
        public PenguinEgg()
        {
            DragonName = "Penguin Dragon Egg";
            Elements = ["Dark", "Ice"];
            HatchingDuration = TimeSpan.FromHours(18);
TargetDragonClassName = "Dragons.PenguinDragon";
            Cost = Int32.MaxValue;
            HatchXP = 100000;
            BreedingTime = TimeSpan.FromHours(12);
        }
    }
}
