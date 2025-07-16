namespace DragonCLI.Dragons
{
    public class QueenDragon : Dragon
    {
        public QueenDragon(string name) : base(name)
        {
            Elements = ["Metal", "Nature"];
            Level = 1;
            GoldRate = 11;
            FormalName = "Queen Dragon";
            IsSpecial = true;
        }


    }
}
