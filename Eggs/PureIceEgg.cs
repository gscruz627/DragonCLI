using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class PureIceEgg : Egg
    {
        public PureIceEgg()
        {
            DragonName = "Pure Ice Dragon Egg";
            Elements = ["Pure", "Ice"];
            HatchingTime = DateTime.Now.AddHours(52);
            TargetDragon = (name) => new PureIceDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 384000;
            BreedingTime = TimeSpan.FromHours(44);
        }
    }
}