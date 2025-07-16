namespace DragonCLI.Dragons
{
    public class AztecDragon : Dragon
    {
        public AztecDragon(string name) : base(name)
        {
            Elements = ["Earth", "Fire"];
            Level = 1;
            GoldRate = 11;
            FormalName = "Aztec Dragon";
            IsSpecial = true;
        }


    }
}
