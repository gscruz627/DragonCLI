using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class WizardEgg : Egg
    {
        public WizardEgg()
        {
            DragonName = "Wizard Dragon Egg";
            Elements = ["Earth", "Dark"];
            HatchingTime = DateTime.Now.AddHours(24);
            TargetDragon = (name) => new WizardDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 150000;
            BreedingTime = TimeSpan.FromHours(16);
        }
    }
}