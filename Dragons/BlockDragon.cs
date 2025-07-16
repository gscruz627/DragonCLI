namespace DragonCLI.Dragons
{
    public class BlockDragon : Dragon
    {
        public BlockDragon(string name) : base(name)
        {
            Elements = ["Dark", "Electric"];
            Level = 1;
            GoldRate = 10;
            FormalName = "Air Dragon";
            IsSpecial = true;
        }


    }
}
