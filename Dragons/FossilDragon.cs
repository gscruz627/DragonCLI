namespace DragonCLI.Dragons
{
    public class FossilDragon : Dragon
    {
        public FossilDragon(string name) : base(name)
        {
            Elements = ["Ice", "Dark"];
            Level = 1;
            GoldRate = 11;
            FormalName = "Fossil Dragon";
            IsSpecial = true;
        }


    }
}
