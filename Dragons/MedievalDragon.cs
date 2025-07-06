namespace DragonCLI.Dragons
{
    public class MedievalDragon : Dragon
    {
        public MedievalDragon(string name) : base(name)
        {
            Elements = ["Fire", "Metal"];
            Level = 1;
            GoldRate = 7;
            FormalName = "Medieval Dragon";
        }


    }
}
