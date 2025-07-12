using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class VikingEgg : Egg
    {
        public VikingEgg()
        {
            DragonName = "Viking Dragon Egg";
            Elements = ["Water", "Ice"];
            HatchingDuration = TimeSpan.FromHours(24);
TargetDragonClassName = "Dragons.VikingDragon";
            Cost = Int32.MaxValue;
            HatchXP = 150000;
            BreedingTime = TimeSpan.FromHours(16);
        }
    }
}
