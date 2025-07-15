using Newtonsoft.Json;

namespace DragonCLI.Habitats
{
    public class NatureHabitat : Habitat
    {
        [JsonConstructor]
        public NatureHabitat()
        {
            AllowedElements = new List<string>();
            Occupants = new List<Guid>();
        }
        public static NatureHabitat CreateDefault()
        {
            var habitat = new NatureHabitat();
            habitat.Name = "Nature";
            habitat.AllowedElements = ["Nature"];
            habitat.Level = 1;
            habitat.MaxCapacity = 2;
            habitat.Gold = 0;
            habitat.MaxGoldCapacity = 10000;
            habitat.Occupants = [];
            habitat.GoldLastCollected = DateTime.Now;
            return habitat;
        }
    }
}
