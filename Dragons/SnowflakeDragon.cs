namespace DragonCLI.Dragons
{
    internal class SnowflakeDragon : Dragon
    {
        public SnowflakeDragon(string name) : base(name)
        {
            Elements = ["Ice", "Earth"];
            Level = 1;
            GoldRate = 10;
            FormalName = "Snowflake Dragon";
        }
    }
}
