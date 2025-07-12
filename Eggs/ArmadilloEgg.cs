using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class ArmadilloEgg : Egg
    {
        public ArmadilloEgg()
        {
            DragonName = "Armadillo Dragon Egg";
            Elements = ["Metal", "Earth"];
            HatchingDuration = TimeSpan.FromHours(15);
TargetDragonClassName = "Dragons.ArmadilloDragon";
            Cost = Int32.MaxValue;
            HatchXP = 5000;
            BreedingTime = TimeSpan.FromHours(9);
        }
    }
}
