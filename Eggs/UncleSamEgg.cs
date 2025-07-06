using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class UncleSamEgg : Egg
    {
        public UncleSamEgg()
        {
            DragonName = "Uncle Sam Dragon Egg";
            Elements = ["Electric", "Metal"];
            HatchingTime = DateTime.Now.AddHours(15);
            TargetDragon = (name) => new UncleSamDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 30000;
            BreedingTime = TimeSpan.FromHours(9);
        }
    }
}