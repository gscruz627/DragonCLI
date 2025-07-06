namespace DragonCLI.Dragons
{
    public class ZombieDragon : Dragon
    {
        public ZombieDragon(string name) : base(name)
        {
            Elements = ["Metal", "Dark"];
            Level = 1;
            GoldRate = 7;
            FormalName = "Zombie Dragon";
        }


    }
}
