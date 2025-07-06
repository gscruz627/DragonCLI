using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class FluorescentEgg : Egg
    {
        public FluorescentEgg()
        {
            DragonName = "Fluorescent Dragon Egg";
            Elements = ["Electric", "Ice"];
            HatchingTime = DateTime.Now.AddHours(19);
            TargetDragon = (name) => new FluorescentDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 5000;
            BreedingTime = TimeSpan.FromHours(13);
        }
    }
}