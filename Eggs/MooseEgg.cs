using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class MooseEgg : Egg
    {
        public MooseEgg()
        {
            DragonName = "Moose Dragon Egg";
            Elements = ["Ice", "Electric"];
            HatchingDuration = TimeSpan.FromHours(15);
TargetDragonClassName = "Dragons.MooseDragon";
            Cost = Int32.MaxValue;
            HatchXP = 8000;
            BreedingTime = TimeSpan.FromHours(9);
        }
    }
}
