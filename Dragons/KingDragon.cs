namespace DragonCLI.Dragons
{
    public class KingDragon : Dragon
    {
        public KingDragon(string name) : base(name)
        {
            Elements = ["Fire", "Metal"];
            Level = 1;
            GoldRate = 11;
            FormalName = "King Dragon";
        }


    }
}
