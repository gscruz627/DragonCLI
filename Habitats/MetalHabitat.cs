using Newtonsoft.Json;
namespace DragonCLI.Habitats
{
    public class MetalHabitat : Habitat
    {
        [JsonConstructor]
        public MetalHabitat()
        {
            AllowedElements = new List<string>();
            Occupants = new List<Guid>();
        }
        public static MetalHabitat CreateDefault()
        {
            var habitat = new MetalHabitat();
            habitat.Name = "Metal";
            habitat.AllowedElements = ["Metal"];
            habitat.Level = 1;
            habitat.MaxCapacity = 2;
            habitat.Gold = 0;
            habitat.MaxGoldCapacity = 17500;
            habitat.Occupants = [];
            habitat.GoldLastCollected = DateTime.Now;
            return habitat;
        }
    }
}
