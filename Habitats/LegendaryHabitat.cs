using Newtonsoft.Json;

namespace DragonCLI.Habitats
{
    public class LegendaryHabitat : Habitat
    {
        [JsonConstructor]
        public LegendaryHabitat()
        {
            AllowedElements = new List<string>();
            Occupants = new List<Guid>();
        }
        public static LegendaryHabitat CreateDefault()
        {
            var habitat = new LegendaryHabitat();
            habitat.Name = "Legendary";
            habitat.AllowedElements = ["Lengendary"];
            habitat.Level = 1;
            habitat.MaxCapacity = 2;
            habitat.Gold = 0;
            habitat.MaxGoldCapacity = 750000;
            habitat.Occupants = [];
            habitat.GoldLastCollected = DateTime.Now;
            return habitat;
        }
    }
}
