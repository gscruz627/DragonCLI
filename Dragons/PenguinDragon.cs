namespace DragonCLI.Dragons
{
    public class PenguinDragon : Dragon
    {
        public PenguinDragon(string name) : base(name)
        {
            Elements = ["Dark", "Ice"];
            Level = 1;
            GoldRate = 6;
            FormalName = "Penguin Dragon";
        }


    }
}
