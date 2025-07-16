namespace DragonCLI.Dragons
{
    public class JellyfishDragon : Dragon
    {
        public JellyfishDragon(string name) : base(name)
        {
            Elements = ["Nature", "Water"];
            Level = 1;
            GoldRate = 10;
            FormalName = "Jellyfish Dragon";
            IsSpecial = true;
        }


    }
}
