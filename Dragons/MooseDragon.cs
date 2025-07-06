namespace DragonCLI.Dragons
{
    public class MooseDragon : Dragon
    {
        public MooseDragon(string name) : base(name)
        {
            Elements = ["Ice", "Electric"];
            Level = 1;
            GoldRate = 6;
            FormalName = "Moose Dragon";
        }


    }
}
