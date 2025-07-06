namespace DragonCLI.Dragons
{
    public class GoldDragon : Dragon
    {
        public GoldDragon(string name) : base(name)
        {
            Elements = ["Electric", "Metal"];
            Level = 1;
            GoldRate = 8;
            FormalName = "Gold Dragon";
        }


    }
}
