namespace DragonCLI.Eggs
{
    public class WaterfallEgg : Egg
    {
        public WaterfallEgg()
        {
            DragonName = "Waterfall Dragon Egg";
            Elements = ["Earth", "Water"];
            HatchingDuration = TimeSpan.FromHours(4);
TargetDragonClassName = "Dragons.WaterfallDragon";
            Cost = Int32.MaxValue;
            HatchXP = 100;
            BreedingTime = TimeSpan.FromHours(4);
        }
    }
}
