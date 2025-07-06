using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class BrontosaurusEgg : Egg
    {
        public BrontosaurusEgg()
        {
            DragonName = "Brontosaurus Dragon Egg";
            Elements = ["Nature", "Earth"];
            HatchingTime = DateTime.Now.AddHours(15);
            TargetDragon = (name) => new BrontosaurusDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 30000;
            BreedingTime = TimeSpan.FromHours(9);
        }
    }
}