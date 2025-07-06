namespace DragonCLI.Dragons
{
    public class AlienDragon : Dragon
    {
        public AlienDragon(string name) : base(name)
        {
            Elements = ["Metal", "Water"];
            Level = 1;
            GoldRate = 10;
            FormalName = "Alien Dragon";
        }


    }
}
