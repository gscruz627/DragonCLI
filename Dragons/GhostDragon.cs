namespace DragonCLI.Dragons
{
    public class GhostDragon : Dragon
    {
        public GhostDragon(string name) : base(name)
        {
            Elements = ["Dark", "Earth"];
            Level = 1;
            GoldRate = 10;
            FormalName = "Ghost Dragon";
        }


    }
}
