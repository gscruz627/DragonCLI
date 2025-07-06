namespace DragonCLI.Dragons
{
    public class PureElectricDragon : Dragon
    {
        public PureElectricDragon(string name) : base(name)
        {
            Elements = ["Pure", "Electric"];
            Level = 1;
            GoldRate = 26;
            FormalName = "Pure Electric Dragon";
        }


    }
}
