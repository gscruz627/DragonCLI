using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class ArmadilloEgg : Egg
    {
        public ArmadilloEgg()
        {
            DragonName = "Armadillo Dragon Egg";
            Elements = ["Metal", "Earth"];
            HatchingTime = DateTime.Now.AddHours(15);
            TargetDragon = (name) => new ArmadilloDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 5000;
            BreedingTime = TimeSpan.FromHours(9);
        }
    }
}