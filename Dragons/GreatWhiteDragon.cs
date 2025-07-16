namespace DragonCLI.Dragons
{
    public class GreatWhiteDragon : Dragon
    {
        public GreatWhiteDragon(string name) : base(name)
        {
            Elements = ["Ice", "Earth"];
            Level = 1;
            GoldRate = 10;
            FormalName = "Great White Dragon";
            IsSpecial = true;
        }


    }
}
