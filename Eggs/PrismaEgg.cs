using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class PrismaEgg : Egg
    {
        public PrismaEgg()
        {
            DragonName = "Prisma Dragon Egg";
            Elements = ["Ice", "Electric"];
            HatchingTime = DateTime.Now.AddHours(36);
            TargetDragon = (name) => new PrismaDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 200000;
            BreedingTime = TimeSpan.FromHours(28);
        }
    }
}