using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class VampireEgg : Egg
    {
        public VampireEgg()
        {
            DragonName = "Vampire Dragon Egg";
            Elements = ["Fire","Dark"];
            HatchingDuration = TimeSpan.FromHours(19);
TargetDragonClassName = "Dragons.VampireDragon";
            Cost = Int32.MaxValue;
            HatchXP = 100000;
            BreedingTime = TimeSpan.FromHours(13);
        }
    }
}
