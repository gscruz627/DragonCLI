namespace DragonCLI.Dragons
{
    public class CarnivorousPlantDragon : Dragon
    {
        public CarnivorousPlantDragon(string name) : base(name)
        {
            Elements = ["Nature", "Dark"];
            Level = 1;
            GoldRate = 9;
            FormalName = "Carnivorous Plant Dragon";
        }


    }
}
