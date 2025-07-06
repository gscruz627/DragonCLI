namespace DragonCLI.Dragons
{
    public class PlatinumDragon : Dragon
    {
        public PlatinumDragon(string name) : base(name)
        {
            Elements = ["Metal", "Ice"];
            Level = 1;
            GoldRate = 5;
            FormalName = "Platinum Dragon";
        }


    }
}
