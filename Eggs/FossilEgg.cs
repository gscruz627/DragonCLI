using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class FossilEgg : Egg
    {
        public FossilEgg()
        {
            DragonName = "Fossil Dragon Egg";
            Elements = ["Dark", "Ice"];
            HatchingDuration = TimeSpan.FromHours(24);
TargetDragonClassName = "Dragons.FossilDragon";
            Cost = Int32.MaxValue;
            HatchXP = 50000;
            BreedingTime = TimeSpan.FromHours(16);
        }
    }
}
