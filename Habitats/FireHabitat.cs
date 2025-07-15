using Newtonsoft.Json;

namespace DragonCLI.Habitats
{
    public class FireHabitat : Habitat
    {
        [JsonConstructor]
        public FireHabitat()
        {
            AllowedElements = new List<string>();
            Occupants = new List<Guid>();
        }
        public static FireHabitat CreateDefault()
        {
            var habitat = new FireHabitat();
            habitat.Name = "Fire";
            habitat.Level = 1;
            habitat.AllowedElements = ["Fire"];
            habitat.MaxCapacity = 2;
            habitat.Occupants = [];
            habitat.Gold = 0;
            habitat.MaxGoldCapacity = 5000;
            habitat.GoldLastCollected = DateTime.Now;
            return habitat;
        }

    }
}
