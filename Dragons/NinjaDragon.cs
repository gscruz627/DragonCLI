namespace DragonCLI.Dragons
{
    public class NinjaDragon : Dragon
    {
        public NinjaDragon(string name) : base(name)
        {
            Elements = ["Metal", "Nature"];
            Level = 1;
            GoldRate = 10;
            FormalName = "Ninja Dragon";
        }


    }
}
