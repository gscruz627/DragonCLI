using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class FluorescentEgg : Egg
    {
        public FluorescentEgg()
        {
            DragonName = "Fluorescent Dragon Egg";
            Elements = ["Electric", "Ice"];
            HatchingDuration = TimeSpan.FromHours(19);
TargetDragonClassName = "Dragons.FluorescentDragon";
            Cost = Int32.MaxValue;
            HatchXP = 5000;
            BreedingTime = TimeSpan.FromHours(13);
        }
    }
}
