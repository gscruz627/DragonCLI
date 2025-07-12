using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class BlockEgg : Egg
    {
        public BlockEgg()
        {
            DragonName = "Block Dragon Egg";
            Elements = ["Electric", "Dark"];
            HatchingDuration = TimeSpan.FromHours(15);
TargetDragonClassName = "Dragons.BlockDragon";
            Cost = Int32.MaxValue;
            HatchXP = 30000;
            BreedingTime = TimeSpan.FromHours(9);
        }
    }
}
