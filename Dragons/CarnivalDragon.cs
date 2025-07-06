namespace DragonCLI.Dragons
{
    public class CarnivalDragon : Dragon
    {
        public CarnivalDragon(string name) : base(name)
        {
            Elements = ["Metal", "Fire"];
            Level = 1;
            GoldRate = 10;
            FormalName = "Carnival Dragon";
        }


    }
}
