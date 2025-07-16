namespace DragonCLI.Dragons
{
    public class JellyDragon : Dragon
    {
        public JellyDragon(string name) : base(name)
        {
            Elements = ["Water", "Earth"];
            Level = 1;
            GoldRate = 10;
            FormalName = "Jelly Dragon";
            IsSpecial = true;
        }


    }
}
