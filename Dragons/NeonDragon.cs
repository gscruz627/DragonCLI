namespace DragonCLI.Dragons
{
    public class NeonDragon : Dragon
    {
        public NeonDragon(string name) : base(name)
        {
            Elements = ["Dark", "Electric"];
            Level = 1;
            GoldRate = 10;
            FormalName = "Neon Dragon";
        }


    }
}
