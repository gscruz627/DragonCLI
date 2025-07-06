using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class CarnivorousPlantEgg : Egg
    {
        public CarnivorousPlantEgg()
        {
            DragonName = "Carnivorous Plant Dragon Egg";
            Elements = ["Nature", "Dark"];
            HatchingTime = DateTime.Now.AddHours(19);
            TargetDragon = (name) => new CarnivorousPlantDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 50000;
            BreedingTime = TimeSpan.FromHours(13);
        }
    }
}