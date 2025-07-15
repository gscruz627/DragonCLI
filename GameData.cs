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
        public Dictionary<string, bool> DiscoveredDragons { get; set; }

        public DateTime LastUpdated { get; set; }
        public GameData()
        {

        }

        public void InitializeNewGame()
        {
            Gold = 0;
            Level = 1;
            Food = 0;
            CurrentXP = 0;
            UserBreedingCave = new BreedingCave();
            Farms = [];
            UserHatchery = new Hatchery();
            LastUpdated = DateTime.Now;
            DiscoveredDragons = [];

            // Try to populate the book of dragons.
            var dragonType = typeof(Dragon);

            var allDragonTypes = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(asm => asm.GetTypes())
                .Where(t => !t.IsAbstract && dragonType.IsAssignableFrom(t));

            foreach (var type in allDragonTypes)
            {
                try
                {
                    var instance = (Dragon)Activator.CreateInstance(type, "");
                    string formalName = instance.FormalName;

                    if (!DiscoveredDragons.ContainsKey(formalName))
                    {
                        DiscoveredDragons[formalName] = false;
                    }
                }
                catch (Exception ex)
                {
                    {
                        Console.WriteLine("Failed to initialize Book of dragons. Error: " + ex.Message + " Failing...");
                        Environment.Exit(0);
                    }
                }
            }
            DiscoveredDragons["Earth Dragon"] = true;

        }
    }
}
