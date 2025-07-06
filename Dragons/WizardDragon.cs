namespace DragonCLI.Dragons
{
    public class WizardDragon : Dragon
    {
        public WizardDragon(string name) : base(name)
        {
            Elements = ["Dark", "Earth"];
            Level = 1;
            GoldRate = 11;
            FormalName = "Wizard Dragon";
        }


    }
}
