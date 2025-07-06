using DragonCLI.Dragons;

namespace DragonCLI.Eggs
{
    public class AlpineEgg : Egg
    {
        public AlpineEgg()
        {
            DragonName = "Alpine Dragon Egg";
            Elements = ["Ice", "Earth"];
            HatchingTime = DateTime.Now.AddHours(19);
            TargetDragon = (name) => new AlpineDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 5000;
            BreedingTime = TimeSpan.FromHours(13);
        }
    }
}
