namespace DragonCLI.Dragons
{
    public class IceAndFireDragon : Dragon
    {
        public IceAndFireDragon(string name) : base(name)
        {
            Elements = ["Ice", "Fire"];
            Level = 1;
            GoldRate = 12;
            FormalName = "Ice and Fire Dragon";
        }


    }
}
