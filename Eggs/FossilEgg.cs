using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class FossilEgg : Egg
    {
        public FossilEgg()
        {
            DragonName = "Fossil Dragon Egg";
            Elements = ["Dark", "Ice"];
            HatchingTime = DateTime.Now.AddHours(24);
            TargetDragon = (name) => new FossilDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 50000;
            BreedingTime = TimeSpan.FromHours(16);
        }
    }
}
