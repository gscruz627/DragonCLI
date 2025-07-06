namespace DragonCLI.Dragons
{
    public class AlpineDragon : Dragon
    {
        public AlpineDragon(string name) : base(name)
        {
            Elements = ["Earth", "Ice"];
            Level = 1;
            GoldRate = 10;
            FormalName = "Alpine Dragon";
        }
    }
}
