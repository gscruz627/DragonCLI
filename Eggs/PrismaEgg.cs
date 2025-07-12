using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class PrismaEgg : Egg
    {
        public PrismaEgg()
        {
            DragonName = "Prisma Dragon Egg";
            Elements = ["Ice", "Electric"];
            HatchingDuration = TimeSpan.FromHours(36);
TargetDragonClassName = "Dragons.PrismaDragon";
            Cost = Int32.MaxValue;
            HatchXP = 200000;
            BreedingTime = TimeSpan.FromHours(28);
        }
    }
}
