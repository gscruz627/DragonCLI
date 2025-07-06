using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class SnowflakeEgg : Egg
    {
        public SnowflakeEgg()
        {
            DragonName = "Snowflake Dragon Egg";
            Elements = ["Ice", "Earth"];
            HatchingTime = DateTime.Now.AddHours(15);
            TargetDragon = (name) => new SnowflakeDragon(name);
            Cost = Int32.MaxValue;
            HatchXP = 8000;
            BreedingTime = TimeSpan.FromHours(9);
        }
    }
}
