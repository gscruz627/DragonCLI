using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class MirrorEgg : Egg
    {
        public MirrorEgg()
        {
            DragonName = "Mirror Dragon Egg";
            Elements = ["Legendary"];
            HatchingTime = DateTime.Now.AddHours(58);
            TargetDragon = (name) => new MirrorDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 432000;
            BreedingTime = TimeSpan.FromHours(50);
        }
    }
}