using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DragonCLI.Dragons;
using DragonCLI.Habitats;

namespace DragonCLI
{
    public class GameData
    {
        public int Gold { get; set; }
        public int Level { get; set; }
        public int Food { get; set; }
        public int CurrentXP { get; set; }
        public BreedingCave UserBreedingCave { get; set; }
        public List<Dragon> Dragons { get; set; }
        public List<Habitat> Habitats { get; set; }
        public List<Farm> Farms { get; set; }
        public Hatchery UserHatchery { get; set; }

        public DateTime LastUpdated {  get; set; }

        public GameData()
        {
            Gold = 10000000;
            Level = 1;
            Food = 10000000;
            CurrentXP = 0;
            UserBreedingCave = new BreedingCave();
            Dragon initialDragon = new EarthDragon(Dragon.GetRandomName());
            Dragons = [initialDragon];
            Habitat initialHabitat = new EarthHabitat();
            initialHabitat.Occupants.Add(initialDragon);
            Habitats = [initialHabitat];
            Farms = [];
            UserHatchery = new Hatchery();
            LastUpdated = DateTime.Now;
        }
    }
}
