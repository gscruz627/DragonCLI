using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class VenomEgg : Egg
    {
        public VenomEgg()
        {
            DragonName = "Venom Dragon Egg";
            Elements = ["Earth", "Dark"];
            HatchingTime = DateTime.Now.AddHours(15);
            TargetDragon = (name) => new VenomDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 10000;
            BreedingTime = TimeSpan.FromHours(9);
        }
    }
}