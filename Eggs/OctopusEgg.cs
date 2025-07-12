using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class OctopusEgg : Egg
    {
        public OctopusEgg()
        {
            DragonName = "Octopus Dragon Egg";
            Elements = ["Water", "Dark"];
            HatchingDuration = TimeSpan.FromHours(15);
TargetDragonClassName = "Dragons.OctopusDragon";
            Cost = Int32.MaxValue;
            HatchXP = 30000;
            BreedingTime = TimeSpan.FromHours(9);
        }
    }
}
