namespace DragonCLI.Dragons
{
    public class PlanktonDragon : Dragon
    {
        public PlanktonDragon(string name) : base(name)
        {
            Elements = ["Water", "Earth"];
            Level = 1;
            GoldRate = 10;
            FormalName = "Plankton Dragon";
        }


    }
}
