using Newtonsoft.Json;


namespace DragonCLI.Habitats
{
    public class PureHabitat : Habitat
    {
        [JsonConstructor]
        public PureHabitat()
        {
            AllowedElements = new List<string>();
            Occupants = new List<Guid>();
        }
        public static PureHabitat CreateDefault()
        {
            var habitat = new PureHabitat();
            habitat.Name = "Pure";
            habitat.AllowedElements = ["Pure"];
            habitat.Level = 1;
            habitat.MaxCapacity = 2;
            habitat.Gold = 0;
            habitat.MaxGoldCapacity = 80000;
            habitat.Occupants = [];
            habitat.GoldLastCollected = DateTime.Now;
            return habitat;
        }

    }
}
