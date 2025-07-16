namespace DragonCLI.Dragons
{
    public class HydraDragon : Dragon
    {
        public HydraDragon(string name) : base(name)
        {
            Elements = ["Electric", "Water"];
            Level = 1;
            GoldRate = 13;
            FormalName = "Hydra Dragon";
            IsSpecial = true;
        }


    }
}
