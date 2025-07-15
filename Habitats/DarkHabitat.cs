using Newtonsoft.Json;

namespace DragonCLI.Habitats
{
    public class DarkHabitat : Habitat
    {
        [JsonConstructor]
        public DarkHabitat()
        {
            AllowedElements = new List<string>();
            Occupants = new List<Guid>();
        }
        public static DarkHabitat CreateDefault()
        {
            var habitat = new DarkHabitat();
            habitat.Name = "Dark";
            habitat.AllowedElements = ["Dark"];
            habitat.Level = 1;
            habitat.MaxCapacity = 2;
            habitat.Gold = 0;
            habitat.MaxGoldCapacity = 20000;
            habitat.Occupants = [];
            habitat.GoldLastCollected = DateTime.Now;
            return habitat;
        }
    }
}
