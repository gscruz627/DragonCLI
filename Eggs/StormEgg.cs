namespace DragonCLI.Eggs
{
    public class StormEgg : Egg
    {
        public StormEgg()
        {
            DragonName = "Storm Dragon Egg";
            Elements = ["Water", "Electric"];
            HatchingDuration = TimeSpan.FromHours(15);
TargetDragonClassName = "Dragons.StormDragon";
            Cost = Int32.MaxValue;
            HatchXP = 5000;
            BreedingTime = TimeSpan.FromHours(9);
        }
    }
}
