using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class OctopusEgg : Egg
    {
        public OctopusEgg()
        {
            DragonName = "Octopus Dragon Egg";
            Elements = ["Water", "Dark"];
            HatchingTime = DateTime.Now.AddHours(15);
            TargetDragon = (name) => new OctopusDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 30000;
            BreedingTime = TimeSpan.FromHours(9);
        }
    }
}
