using DragonCLI.Dragons;

namespace DragonCLI.Eggs
{
    public class StarEgg : Egg
    {
        public StarEgg()
        {
            DragonName = "Star Dragon Egg";
            Elements = ["Earth", "Electric"];
            HatchingTime = DateTime.Now.AddHours(9);
            TargetDragon = (name) => new StarDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 5000;
            BreedingTime = TimeSpan.FromHours(7);
        }
    }
}
