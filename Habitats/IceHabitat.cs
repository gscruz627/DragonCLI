using Newtonsoft.Json;

namespace DragonCLI.Habitats
{
    public class IceHabitat : Habitat
    {
        [JsonConstructor]
        public IceHabitat()
        {
            AllowedElements = new List<string>();
            Occupants = new List<Guid>();
        }
        public static IceHabitat CreateDefault()
        {
            var habitat = new IceHabitat();
            habitat.Name = "Ice";
            habitat.AllowedElements = ["Ice"];
            habitat.Level = 1;
            habitat.MaxCapacity = 2;
            habitat.Gold = 0;
            habitat.MaxGoldCapacity = 15000;
            habitat.Occupants = [];
            habitat.GoldLastCollected = DateTime.Now;
            return habitat;
        }
    }
}
