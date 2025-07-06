namespace DragonCLI.Dragons
{
    public class SoccerDragon : Dragon
    {
        public SoccerDragon(string name) : base(name)
        {
            Elements = ["Ice", "Fire"];
            Level = 1;
            GoldRate = 5;
            FormalName = "Soccer Dragon";
            IsRare = true;
        }


    }
}
