namespace DragonCLI.Dragons
{
    public class SantaDragon : Dragon
    {
        public SantaDragon(string name) : base(name)
        {
            Elements = ["Earth", "Ice"];
            Level = 1;
            GoldRate = 9;
            FormalName = "Santa Dragon";
            IsSpecial = true;
        }


    }
}
