using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class MirrorEgg : Egg
    {
        public MirrorEgg()
        {
            DragonName = "Mirror Dragon Egg";
            Elements = ["Legendary"];
            HatchingDuration = TimeSpan.FromHours(58);
TargetDragonClassName = "Dragons.MirrorDragon";
            Cost = Int32.MaxValue;
            HatchXP = 432000;
            BreedingTime = TimeSpan.FromHours(50);
        }
    }
}
