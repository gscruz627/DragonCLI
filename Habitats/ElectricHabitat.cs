using Newtonsoft.Json;

namespace DragonCLI.Habitats
{
    public class ElectricHabitat : Habitat

    {
        [JsonConstructor]
        public ElectricHabitat()
        {
            AllowedElements = new List<string>();
            Occupants = new List<Guid>();
        }
        public static ElectricHabitat CreateDefault()
        {
            var habitat = new ElectricHabitat();
            habitat.Name = "Electric";
            habitat.AllowedElements = ["Electric"];
            habitat.Level = 1;
            habitat.MaxCapacity = 2;
            habitat.Gold = 0;
            habitat.MaxGoldCapacity = 12500;
            habitat.Occupants = [];
            habitat.GoldLastCollected = DateTime.Now;
            return habitat;
        }
    }
}
