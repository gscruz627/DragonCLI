using DragonCLI.Dragons;

namespace DragonCLI.Eggs
{
    public class IceEgg : Egg
    {
        public IceEgg()
        {
            DragonName = "Ice Dragon Egg";
            Elements = ["Ice"];
            HatchingDuration = TimeSpan.FromHours(15);
TargetDragonClassName = "Dragons.IceDragon";
            Cost = 15000;
            HatchXP = 5000;
            BreedingTime = TimeSpan.FromHours(9);
        }
    }
}
