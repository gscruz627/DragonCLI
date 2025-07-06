namespace DragonCLI.Dragons
{
    public class IceCubeDragon : Dragon
    {
        public IceCubeDragon(string name) : base(name)
        {
            Elements = ["Ice", "Water"];
            Level = 1;
            GoldRate = 3;
            FormalName = "Ice Cube Dragon";
        }
    }
}
