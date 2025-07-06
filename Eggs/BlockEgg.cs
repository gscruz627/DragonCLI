using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class BlockEgg : Egg
    {
        public BlockEgg()
        {
            DragonName = "Block Dragon Egg";
            Elements = ["Electric", "Dark"];
            HatchingTime = DateTime.Now.AddHours(15);
            TargetDragon = (name) => new BlockDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 30000;
            BreedingTime = TimeSpan.FromHours(9);
        }
    }
}