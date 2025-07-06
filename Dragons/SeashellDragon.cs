namespace DragonCLI.Dragons
{
    public class SeashellDragon : Dragon
    {
        public SeashellDragon(string name) : base(name)
        {
            Elements = ["Water", "Metal"];
            Level = 1;
            GoldRate = 8;
            FormalName = "Seashell Dragon";
        }
    }
}
