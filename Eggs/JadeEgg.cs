using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class JadeEgg : Egg
    {
        public JadeEgg()
        {
            DragonName = "Jade Dragon Egg";
            Elements = ["Nature", "Metal"];
            HatchingDuration = TimeSpan.FromHours(19);
TargetDragonClassName = "Dragons.JadeDragon";
            Cost = Int32.MaxValue;
            HatchXP = 5000;
            BreedingTime = TimeSpan.FromHours(13);
        }
    }
}
