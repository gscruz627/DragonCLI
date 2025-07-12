using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class JellyfishEgg : Egg
    {
        public JellyfishEgg()
        {
            DragonName = "Jellyfish Dragon Egg";
            Elements = ["Nature", "Water"];
            HatchingDuration = TimeSpan.FromHours(15);
TargetDragonClassName = "Dragons.JellyfishDragon";
            Cost = Int32.MaxValue;
            HatchXP = 30000;
            BreedingTime = TimeSpan.FromHours(9);
        }
    }
}
