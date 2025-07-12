using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class CarnivorousPlantEgg : Egg
    {
        public CarnivorousPlantEgg()
        {
            DragonName = "Carnivorous Plant Dragon Egg";
            Elements = ["Nature", "Dark"];
            HatchingDuration = TimeSpan.FromHours(19);
TargetDragonClassName = "Dragons.CarnivorousPlantDragon";
            Cost = Int32.MaxValue;
            HatchXP = 50000;
            BreedingTime = TimeSpan.FromHours(13);
        }
    }
}
