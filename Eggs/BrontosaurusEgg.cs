using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class BrontosaurusEgg : Egg
    {
        public BrontosaurusEgg()
        {
            DragonName = "Brontosaurus Dragon Egg";
            Elements = ["Nature", "Earth"];
            HatchingDuration = TimeSpan.FromHours(15);
TargetDragonClassName = "Dragons.BrontosaurusDragon";
            Cost = Int32.MaxValue;
            HatchXP = 30000;
            BreedingTime = TimeSpan.FromHours(9);
        }
    }
}
