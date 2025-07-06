namespace DragonCLI.Dragons
{
    public class LegendaryDragon : Dragon
    {
        public LegendaryDragon(string name) : base(name)
        {
            Elements = ["Legendary"];
            Level = 1;
            GoldRate = 32;
            FormalName = "Legendary Dragon";
        }


    }
}
