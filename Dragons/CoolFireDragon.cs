namespace DragonCLI.Dragons
{
    public class CoolFireDragon : Dragon
    {
        public CoolFireDragon(string name) : base(name)
        {
            Elements = ["Fire", "Ice"];
            Level = 1;
            GoldRate = 5;
            FormalName = "Cool Fire Dragon";
            IsRare = true;
        }


    }
}
