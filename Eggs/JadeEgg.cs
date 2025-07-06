using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class JadeEgg : Egg
    {
        public JadeEgg()
        {
            DragonName = "Jade Dragon Egg";
            Elements = ["Nature", "Metal"];
            HatchingTime = DateTime.Now.AddHours(19);
            TargetDragon = (name) => new JadeDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 5000;
            BreedingTime = TimeSpan.FromHours(13);
        }
    }
}