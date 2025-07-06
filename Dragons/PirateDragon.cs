namespace DragonCLI.Dragons
{
    public class PirateDragon : Dragon
    {
        public PirateDragon(string name) : base(name)
        {
            Elements = ["Dark", "Water"];
            Level = 1;
            GoldRate = 8;
            FormalName = "Pirates Dragon";
            IsRare = true;
        }


    }
}
