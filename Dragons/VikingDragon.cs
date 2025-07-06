namespace DragonCLI.Dragons
{
    public class VikingDragon : Dragon
    {
        public VikingDragon(string name) : base(name)
        {
            Elements = ["Water", "Ice"];
            Level = 1;
            GoldRate = 11;
            FormalName = "Viking Dragon";
        }


    }
}
