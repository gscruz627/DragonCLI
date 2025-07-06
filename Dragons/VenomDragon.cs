namespace DragonCLI.Dragons
{
    public class VenomDragon : Dragon
    {
        public VenomDragon(string name) : base(name)
        {
            Elements = ["Dark", "Earth"];
            Level = 1;
            GoldRate = 9;
            FormalName = "Venom Dragon";
        }


    }
}
