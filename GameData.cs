using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public GameData()
        {
            Gold = 0;
            Level = 1;
            Food = 0;
            CurrentXP = 0;
            UserBreedingCave = new BreedingCave();
            Dragons = [];
            Habitats = [];
            Farms = [];
            UserHatchery = new Hatchery();
        }
    }
}
