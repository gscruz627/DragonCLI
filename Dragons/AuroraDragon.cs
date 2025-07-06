namespace DragonCLI.Dragons
{
    public class AuroraDragon : Dragon
    {
        public AuroraDragon(string name) : base(name)
        {
            Elements = ["Electric", "Fire"];
            Level = 1;
            GoldRate = 10;
            FormalName = "Aurora Dragon";
        }


    }
}
