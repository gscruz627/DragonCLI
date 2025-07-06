using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class VikingEgg : Egg
    {
        public VikingEgg()
        {
            DragonName = "Viking Dragon Egg";
            Elements = ["Water", "Ice"];
            HatchingTime = DateTime.Now.AddHours(24);
            TargetDragon = (name) => new VikingDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 150000;
            BreedingTime = TimeSpan.FromHours(16);
        }
    }
}