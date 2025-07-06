namespace DragonCLI.Dragons
{
    public class MetalDragon : Dragon
    {
        public MetalDragon(string name) : base(name)
        {
            Elements = ["Metal"];
            Level = 1;
            GoldRate = 6;
            FormalName = "Metal Dragon";
        }


    }
}
