using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class VampireEgg : Egg
    {
        public VampireEgg()
        {
            DragonName = "Vampire Dragon Egg";
            Elements = ["Fire","Dark"];
            HatchingTime = DateTime.Now.AddHours(19);
            TargetDragon = (name) => new VampireDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 100000;
            BreedingTime = TimeSpan.FromHours(13);
        }
    }
}