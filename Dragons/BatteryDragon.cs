namespace DragonCLI.Dragons
{
    public class BatteryDragon : Dragon
    {
        public BatteryDragon(string name) : base(name)
        {
            Elements = ["Electric", "Metal"];
            Level = 1;
            GoldRate = 9;
            FormalName = "Battery Dragon";
        }


    }
}
