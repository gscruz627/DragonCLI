using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class WizardEgg : Egg
    {
        public WizardEgg()
        {
            DragonName = "Wizard Dragon Egg";
            Elements = ["Earth", "Dark"];
            HatchingDuration = TimeSpan.FromHours(24);
TargetDragonClassName = "Dragons.WizardDragon";
            Cost = Int32.MaxValue;
            HatchXP = 150000;
            BreedingTime = TimeSpan.FromHours(16);
        }
    }
}
