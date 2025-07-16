namespace DragonCLI.Dragons
{
    public class TwoHeadedDragon : Dragon
    {
        public TwoHeadedDragon(string name) : base(name)
        {
            Elements = ["Nature", "Dark"];
            Level = 1;
            GoldRate = 12;
            FormalName = "Two-Headed Dragon";
            IsSpecial = true;
        }


    }
}
