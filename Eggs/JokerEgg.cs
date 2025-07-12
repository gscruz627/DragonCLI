using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class JokerEgg : Egg
    {
        public JokerEgg()
        {
            DragonName = "Joker Dragon Egg";
            Elements = ["Fire", "Dark"];
            HatchingDuration = TimeSpan.FromHours(17);
TargetDragonClassName = "Dragons.JokerDragon";
            Cost = Int32.MaxValue;
            HatchXP = 30000;
            BreedingTime = TimeSpan.FromHours(11);
        }
    }
}
