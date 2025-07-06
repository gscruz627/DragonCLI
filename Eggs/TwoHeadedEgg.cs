using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class TwoHeadedEgg : Egg
    {
        public TwoHeadedEgg()
        {
            DragonName = "Two-Headed Dragon Egg";
            Elements = ["Nature", "Dark"];
            HatchingTime = DateTime.Now.AddHours(36);
            TargetDragon = (name) => new TwoHeadedDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 200000;
            BreedingTime = TimeSpan.FromHours(28);
        }
    }
}