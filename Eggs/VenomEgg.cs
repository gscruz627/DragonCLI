using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class VenomEgg : Egg
    {
        public VenomEgg()
        {
            DragonName = "Venom Dragon Egg";
            Elements = ["Earth", "Dark"];
            HatchingDuration = TimeSpan.FromHours(15);
TargetDragonClassName = "Dragons.VenomDragon";
            Cost = Int32.MaxValue;
            HatchXP = 10000;
            BreedingTime = TimeSpan.FromHours(9);
        }
    }
}
