namespace DragonCLI.Dragons
{
    public class IceCreamDragon : Dragon
    {
        public IceCreamDragon(string name) : base(name)
        {
            Elements = ["Ice", "Water"];
            Level = 1;
            GoldRate = 3;
            FormalName = "Ice Cream Dragon";
        }
    }
}
