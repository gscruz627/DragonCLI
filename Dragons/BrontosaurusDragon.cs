namespace DragonCLI.Dragons
{
    public class BrontosaurusDragon : Dragon
    {
        public BrontosaurusDragon(string name) : base(name)
        {
            Elements = ["Nature", "Earth"];
            Level = 1;
            GoldRate = 10;
            FormalName = "Brontosaurus Dragon";
            IsSpecial = true;
        }


    }
}
