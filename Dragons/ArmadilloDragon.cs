namespace DragonCLI.Dragons
{
    public class ArmadilloDragon : Dragon
    {
        public ArmadilloDragon(string name) : base(name)
        {
            Elements = ["Metal", "Earth"];
            Level = 1;
            GoldRate = 14;
            FormalName = "Armadillo Dragon";
            IsRare = true;
        }


    }
}
