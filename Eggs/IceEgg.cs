using DragonCLI.Dragons;

namespace DragonCLI.Eggs
{
    public class IceEgg : Egg
    {
        public IceEgg()
        {
            DragonName = "Ice Dragon Egg";
            Elements = ["Ice"];
            HatchingTime = DateTime.Now.AddHours(15);
            TargetDragon = (name) => new IceDragon(name);
            Cost = 15000;
            HatchXP = 5000;
            BreedingTime = TimeSpan.FromHours(9);
        }
    }
}
