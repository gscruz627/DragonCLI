using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class MooseEgg : Egg
    {
        public MooseEgg()
        {
            DragonName = "Moose Dragon Egg";
            Elements = ["Ice", "Electric"];
            HatchingTime = DateTime.Now.AddHours(15);
            TargetDragon = (name) => new MooseDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 8000;
            BreedingTime = TimeSpan.FromHours(9);
        }
    }
}