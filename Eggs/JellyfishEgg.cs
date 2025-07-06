using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class JellyfishEgg : Egg
    {
        public JellyfishEgg()
        {
            DragonName = "Jellyfish Dragon Egg";
            Elements = ["Nature", "Water"];
            HatchingTime = DateTime.Now.AddHours(15);
            TargetDragon = (name) => new JellyfishDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 30000;
            BreedingTime = TimeSpan.FromHours(9);
        }
    }
}