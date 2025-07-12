using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class TwoHeadedEgg : Egg
    {
        public TwoHeadedEgg()
        {
            DragonName = "Two-Headed Dragon Egg";
            Elements = ["Nature", "Dark"];
            HatchingDuration = TimeSpan.FromHours(36);
TargetDragonClassName = "Dragons.TwoHeadedDragon";
            Cost = Int32.MaxValue;
            HatchXP = 200000;
            BreedingTime = TimeSpan.FromHours(28);
        }
    }
}
