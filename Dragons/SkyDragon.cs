namespace DragonCLI.Dragons
{
    public class SkyDragon : Dragon
    {
        public SkyDragon(string name) : base(name)
        {
            Elements = ["Electric", "Earth"];
            Level = 1;
            GoldRate = 10;
            FormalName = "Sky Dragon";
            IsSpecial = true;
        }


    }
}
