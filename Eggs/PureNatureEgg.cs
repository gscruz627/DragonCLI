using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class PureNatureEgg : Egg
    {
        public PureNatureEgg()
        {
            DragonName = "Pure Nature Dragon Egg";
            Elements = ["Nature", "Pure"];
            HatchingTime = DateTime.Now.AddHours(52);
            TargetDragon = (name) => new PureNatureDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 384000;
            BreedingTime = TimeSpan.FromHours(44);
        }
    }
}