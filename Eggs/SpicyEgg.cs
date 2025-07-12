namespace DragonCLI.Eggs
{
    public class SpicyEgg : Egg
    {
        public SpicyEgg()
        {
            DragonName = "Spicy Dragon Egg";
            Elements = ["Nature", "Fire"];
            HatchingDuration = TimeSpan.FromHours(13);
TargetDragonClassName = "Dragons.SpicyDragon";
            Cost = Int32.MaxValue;
            HatchXP = 5000;
            BreedingTime = TimeSpan.FromHours(7);
        }
    }
}
