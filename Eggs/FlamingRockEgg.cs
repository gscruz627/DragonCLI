namespace DragonCLI.Eggs
{
    public class FlamingRockEgg : Egg
    {
        public FlamingRockEgg()
        {
            DragonName = "Flaming Rock Dragon Egg";
            Elements = ["Earth", "Fire"];
            HatchingDuration = TimeSpan.FromSeconds(30);
            TargetDragonClassName = "Dragons.FlamingRockDragon";
            Cost = Int32.MaxValue;
            HatchXP = 50;
            BreedingTime = TimeSpan.FromSeconds(30);
        }
    }
}
