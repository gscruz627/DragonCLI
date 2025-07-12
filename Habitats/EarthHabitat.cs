using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DragonCLI.Habitats
{
    public class EarthHabitat : Habitat
    {
        [JsonConstructor]
        public EarthHabitat()
        {
            AllowedElements = new List<string>();
            Occupants = new List<Dragon>();
        }
        public static EarthHabitat CreateDefault()
        {
            var habitat = new EarthHabitat();
            habitat.Name = "Earth";
            habitat.AllowedElements = ["Earth"];
            habitat.Level = 1;
            habitat.MaxCapacity = 2;
            habitat.Gold = 0;
            habitat.MaxGoldCapacity = 500;
            habitat.Occupants = [];
            habitat.GoldLastCollected = DateTime.Now;
            return habitat;
        }
    }
}
