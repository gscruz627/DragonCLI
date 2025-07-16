namespace DragonCLI.Dragons
{
    public class PrismaDragon : Dragon
    {
        public PrismaDragon(string name) : base(name)
        {
            Elements = ["Ice", "Electric"];
            Level = 1;
            GoldRate = 12;
            FormalName = "Prisma Dragon";
            IsSpecial = true;
        }


    }
}
