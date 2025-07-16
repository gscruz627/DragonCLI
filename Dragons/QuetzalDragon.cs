namespace DragonCLI.Dragons
{
    public class QuetzalDragon : Dragon
    {
        public QuetzalDragon(string name) : base(name)
        {
            Elements = ["Fire", "Nature"];
            Level = 1;
            GoldRate = 11;
            FormalName = "Quetzal Dragon";
            IsSpecial = true;
        }


    }
}
