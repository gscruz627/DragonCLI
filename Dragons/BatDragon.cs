namespace DragonCLI.Dragons
{
    public class BatDragon : Dragon
    {
        public BatDragon(string name) : base(name)
        {
            Elements = ["Earth", "Dark"];
            Level = 1;
            GoldRate = 10;
            FormalName = "Bat Dragon";
            IsSpecial = true;
        }


    }
}
