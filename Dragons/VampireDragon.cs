namespace DragonCLI.Dragons
{
    public class VampireDragon : Dragon
    {
        public VampireDragon(string name) : base(name)
        {
            Elements = ["Dark", "Fire"];
            Level = 1;
            GoldRate = 8;
            FormalName = "Vampire Dragon";
        }


    }
}
