using Newtonsoft.Json;

namespace DragonCLI.Habitats
{

    public class WaterHabitat : Habitat
    {
        [JsonConstructor]
        public WaterHabitat()
        {
            AllowedElements = new List<string>();
            Occupants = new List<Guid>();
        }
        public static WaterHabitat CreateDefault()
        {
            var habitat = new WaterHabitat();
            habitat.Name = "Water";
            habitat.AllowedElements = ["Water"];
            habitat.Level = 1;
            habitat.MaxCapacity = 2;
            habitat.Occupants = [];
            habitat.MaxGoldCapacity = 7500;
            habitat.Gold = 0;
            habitat.GoldLastCollected = DateTime.Now;
            return habitat;
        }
    }
}