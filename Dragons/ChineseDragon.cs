namespace DragonCLI.Dragons
{
    public class ChineseDragon : Dragon
    {
        public ChineseDragon(string name) : base(name)
        {
            Elements = ["Fire", "Earth"];
            Level = 1;
            GoldRate = 9;
            FormalName = "Chinese Dragon";
        }


    }
}
