namespace DragonCLI.Dragons
{
    public class PetroleumDragon : Dragon
    {
        public PetroleumDragon(string name) : base(name)
        {
            Elements = ["Water", "Dark"];
            Level = 1;
            GoldRate = 6;
            FormalName = "Petroleum Dragon";
            IsRare = true;
        }


    }
}
