using DragonCLI.Dragons;
namespace DragonCLI.Eggs
{
    public class SnowflakeEgg : Egg
    {
        public SnowflakeEgg()
        {
            DragonName = "Snowflake Dragon Egg";
            Elements = ["Ice", "Earth"];
            HatchingDuration = TimeSpan.FromHours(15);
TargetDragonClassName = "Dragons.SnowflakeDragon";
            Cost = Int32.MaxValue;
            HatchXP = 8000;
            BreedingTime = TimeSpan.FromHours(9);
        }
    }
}
