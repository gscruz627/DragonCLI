using DragonCLI.Eggs;
using DragonCLI.Habitats;
using System.Data;

namespace DragonCLI
{
    public static class Helper
    {
        public static Egg Breed(Dragon dragon1, Dragon dragon2)
        {
            var random = new Random();
            Egg outcome = null;
            string element1 = "";
            string element2 = "";

            bool isLegendary1 = dragon1.Elements.Contains("Legendary");
            bool isLegendary2 = dragon2.Elements.Contains("Legendary");

            bool isRare1 = dragon1.IsRare;
            bool isRare2 = dragon2.IsRare;

            // Both Legendary: return random Legendary dragon
            if (isLegendary1 && isLegendary2)
            {
                int randomIndex = random.Next(BreedingCave.LegendaryDragons.Count);
                outcome = BreedingCave.LegendaryDragons[randomIndex]();
            }
            // Only one is Legendary: use elements from the non-Legendary dragon
            else if (isLegendary1 || isLegendary2)
            {
                Dragon nonLegendary = isLegendary1 ? dragon2 : dragon1;

                // Ensure at least 2 elements to choose from
                var elements = new List<string>(nonLegendary.Elements);
                if (elements.Count < 2)
                {
                    // Duplicate element if only one is available
                    elements.Add(elements[0]);
                }

                // Shuffle and pick two elements randomly
                elements = [.. elements.OrderBy(_ => random.Next())];
                element1 = elements[0];
                element2 = elements[1];

                // Lookup result (assuming you have a method like this)
                outcome = BreedingCave.RegularBreedingTable[element1][element2]();
            }
            else if (isRare1 && isRare2)
            {
                int pick = random.Next(100);
                // Legendary outcome
                if (pick > 90)
                {
                    int randomIndex = random.Next(BreedingCave.LegendaryDragons.Count);
                    outcome = BreedingCave.LegendaryDragons[randomIndex]();
                }
                else
                {
                    if (dragon1.Level >= 10 && dragon2.Level >= 10) { BreedSpecially(); }
                    else { BreedRegularly(); }
                }
            }
            else
            {
                if (dragon1.Level >= 10 && dragon2.Level >= 10) { BreedSpecially(); }
                else { BreedRegularly(); }
            }
            void BreedSpecially()
            {
                int pick = Convert.ToInt32(random.NextInt64(100));
                if (pick < 75)
                {
                    BreedRegularly();
                }
                else
                {
                    element1 = dragon1.Elements[random.Next(dragon1.Elements.Count)];
                    element2 = dragon2.Elements[random.Next(dragon2.Elements.Count)];
                    // Check if entry for these elements exists.
                    if (BreedingCave.SpecialBreedingTable.ContainsKey(element1) && BreedingCave.SpecialBreedingTable[element1].ContainsKey(element2))
                    {
                        outcome = BreedingCave.SpecialBreedingTable[element1][element2]();
                    }
                    else
                    {
                        outcome = BreedingCave.RegularBreedingTable[element1][element2]();
                    }
                }
            }
            void BreedRegularly()
            {
                element1 = dragon1.Elements[random.Next(dragon1.Elements.Count)];
                element2 = dragon2.Elements[random.Next(dragon2.Elements.Count)];
                outcome = BreedingCave.RegularBreedingTable[element1][element2]();
            }
            return outcome;
        }
        public static void WriteLineColored(string line, ConsoleColor color)
        {
            var original = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(line);
            Console.ForegroundColor = original;
        }

        public static void WriteColored(string line, ConsoleColor color)
        {
            var original = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.Write(line);
            Console.ForegroundColor = original;
        }

        public static Dictionary<string, HabitatInfo> AllHabitats = new()
        {
            ["Earth"] = new HabitatInfo
            {
                DisplayName = "Earth",
                Cost = 100,
                BuildDuration = TimeSpan.FromSeconds(10),
                UpdateDuration = TimeSpan.FromSeconds(30),
                BuildXP = 100,
                UpdateXP = 2500,
                UpdateCost = 25000,
                CreateHabitat = () => EarthHabitat.CreateDefault()
            },
            ["Fire"] = new HabitatInfo
            {
                DisplayName = "Fire",
                Cost = 150,
                BuildDuration = TimeSpan.FromSeconds(15),
                UpdateDuration = TimeSpan.FromHours(2),
                BuildXP = 230,
                UpdateXP = 25000,
                UpdateCost = 50000,
                CreateHabitat = () => new FireHabitat()
            },
            ["Water"] = new HabitatInfo
            {
                DisplayName = "Water",
                Cost = 500,
                BuildDuration = TimeSpan.FromSeconds(30),
                UpdateDuration = TimeSpan.FromHours(2.5),
                BuildXP = 500,
                UpdateXP = 75000,
                UpdateCost = 100000,
                CreateHabitat = () => new WaterHabitat()
            },
            ["Nature"] = new HabitatInfo
            {
                DisplayName = "Nature",
                Cost = 1500,
                BuildDuration = TimeSpan.FromHours(1),
                UpdateDuration = TimeSpan.FromHours(3),
                BuildXP = 1500,
                UpdateXP = 125000,
                UpdateCost = 125000,
                CreateHabitat = () => new NatureHabitat()
            },
            ["Electric"] = new HabitatInfo
            {
                DisplayName = "Electric",
                Cost = 30000,
                BuildDuration = TimeSpan.FromHours(2),
                UpdateDuration = TimeSpan.FromHours(8),
                BuildXP = 20000,
                UpdateXP = 250000,
                UpdateCost = 250000,
                CreateHabitat = () => new ElectricHabitat()
            },
            ["Ice"] = new HabitatInfo
            {
                DisplayName = "Ice",
                Cost = 75000,
                BuildDuration = TimeSpan.FromHours(2.5),
                UpdateDuration = TimeSpan.FromHours(12),
                BuildXP = 50000,
                UpdateXP = 500000,
                UpdateCost = 1000000,
                CreateHabitat = () => new IceHabitat()
            },
            ["Metal"] = new HabitatInfo
            {
                DisplayName = "Metal",
                Cost = 100000,
                BuildDuration = TimeSpan.FromHours(3),
                UpdateDuration = TimeSpan.FromHours(18),
                BuildXP = 100000,
                UpdateXP = 1000000,
                UpdateCost = 2000000,
                CreateHabitat = () => new MetalHabitat()
            },
            ["Dark"] = new HabitatInfo
            {
                DisplayName = "Dark",
                Cost = 500000,
                BuildDuration = TimeSpan.FromHours(4),
                UpdateDuration = TimeSpan.FromHours(24),
                BuildXP = 250000,
                UpdateXP = 1500000,
                UpdateCost = 3000000,
                CreateHabitat = () => new DarkHabitat()
            },
            ["Legendary"] = new HabitatInfo
            {
                DisplayName = "Legendary",
                Cost = 1500000,
                BuildDuration = TimeSpan.FromHours(8),
                UpdateDuration = TimeSpan.FromHours(30),
                BuildXP = 5000000,
                UpdateXP = 7000000,
                UpdateCost = 9000000,
                CreateHabitat = () => new LegendaryHabitat()
            },
            ["Pure"] = new HabitatInfo
            {
                DisplayName = "Pure",
                Cost = 700000,
                BuildDuration = TimeSpan.FromHours(6),
                UpdateDuration = TimeSpan.FromHours(30),
                BuildXP = 3750000,
                UpdateXP = 4750000,
                UpdateCost = 4200000,
                CreateHabitat = () => new PureHabitat()
            }
        };
    
        public static Dictionary<string, HabitatInfo> GetAvailableHabitats(in GameData gameData)
        {
            Dictionary<string, HabitatInfo> availableHabitats = [];
            foreach (var kv in Helper.AllHabitats)
            {
                string key = kv.Key;
                if ((key == "Earth" || key == "Fire" || key == "Water") ||
                    (gameData?.Level >= 5 && key == "Nature") ||
                    (gameData?.Level >= 8 && key == "Electric") ||
                    (gameData?.Level >= 10 && key == "Ice") ||
                    (gameData?.Level >= 15 && key == "Metal") ||
                    (gameData?.Level >= 18 && key == "Dark") ||
                    (gameData?.Level >= 21 && key == "Legendary") ||
                    (gameData?.Level >= 35 && key == "Pure"))
                { availableHabitats[key] = kv.Value; }
            }
            return availableHabitats;
        }

        public static int GetHabitatLimit(in GameData gameData)
        {
            int habitatLimit =
                gameData?.Level >= 35 ? 160 :
                gameData?.Level >= 30 ? 140 :
                gameData?.Level >= 25 ? 120 :
                gameData?.Level >= 20 ? 90 :
                gameData?.Level >= 15 ? 50 :
                gameData?.Level >= 10 ? 30 :
                gameData?.Level >= 5 ? 20 :
                gameData?.Level >= 2 ? 5 : 0;
            return habitatLimit;
        }

        public static Dictionary<string, int> GetAvailableEggs(in GameData gameData)
        {
            Dictionary<string, int> availableEggs = new() { { "Earth", 100 }, { "Fire", 100 }, { "Water", 350 } };
            if (gameData?.Level >= 5) availableEggs.Add("Nature", 1000);
            if (gameData?.Level >= 8) availableEggs.Add("Electric", 4500);
            if (gameData?.Level >= 10) availableEggs.Add("Ice", 15000);
            if (gameData?.Level >= 15) availableEggs.Add("Metal", 60000);
            if (gameData?.Level >= 18) availableEggs.Add("Dark", 120000);
            if (gameData?.Level >= 35) availableEggs.Add("Pure", 120000);
            return availableEggs;
        }

        public static Dictionary<string, Func<Egg>> EggFactories = new()
        {
            { "Earth", () => new EarthEgg() },
            { "Fire", () => new FireEgg() },
            { "Water", () => new WaterEgg() },
            { "Nature", () => new NatureEgg() },
            { "Electric", () => new ElectricEgg() },
            { "Ice", () => new IceEgg() },
            { "Metal", () => new MetalEgg() },
            { "Dark", () => new DarkEgg() },
            { "Pure", () => new PureEgg() }
        };

        public static int GetFarmLimit(in GameData gameData)
        {
            int farmsLimit = 1;
            if (gameData?.Level >= 30) farmsLimit = 10;
            else if (gameData?.Level >= 15) farmsLimit = 7;
            else if (gameData?.Level >= 10) farmsLimit = 5;
            else if (gameData?.Level >= 5) farmsLimit = 3;
            return farmsLimit;
        }

        public static readonly int[] xpThresholds = { 1, 200, 500, 1500, 3000, 5000, 10000, 20000,
        35000, 60000, 100000, 150000, 245000, 400000, 700000, 1200000, 2000000, 3000000, 4500000,
        6000000, 7500000, 10000000,12000000,15000000,20000000,22000000,27000000,320000000,38000000,
        45000000,50000000,57000000,65000000,72000000, 80000000,90000000,100000000,110000000, 120000000,
        130000000,140000000,155000000,167000000,180000000,200000000,220000000,230000000,240000000,250000000 };
    }
}
