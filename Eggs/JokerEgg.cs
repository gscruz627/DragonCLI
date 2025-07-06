using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class JokerEgg : Egg
    {
        public JokerEgg()
        {
            DragonName = "Joker Dragon Egg";
            Elements = ["Fire", "Dark"];
            HatchingTime = DateTime.Now.AddHours(17);
            TargetDragon = (name) => new JokerDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 30000;
            BreedingTime = TimeSpan.FromHours(11);
        }
    }
}