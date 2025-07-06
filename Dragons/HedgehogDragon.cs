namespace DragonCLI.Dragons
{
    public class HedgehogDragon : Dragon
    {
        public HedgehogDragon(string name) : base(name)
        {
            Elements = ["Dark", "Earth"];
            Level = 1;
            GoldRate = 13;
            FormalName = "Hedgehog Dragon";
        }


    }
}
