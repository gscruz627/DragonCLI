using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class MojitoEgg : Egg
    {
        public MojitoEgg()
        {
            DragonName = "Mojito Dragon Egg";
            Elements = ["Nature", "Ice"];
            HatchingTime = DateTime.Now.AddHours(15);
            TargetDragon = (name) => new MojitoDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 5000;
            BreedingTime = TimeSpan.FromHours(9);
        }
    }
}
