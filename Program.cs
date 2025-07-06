using DragonCLI.Dragons;
using DragonCLI.Eggs;
using DragonCLI.Habitats;
using Humanizer;
using Humanizer.Localisation;
using System;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DragonCLI
{
    class Program
    {
        static readonly string PROJECT_ROOT = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "DragonCity");
        static readonly string SAVE_FILE = Path.Combine(PROJECT_ROOT, "data.json");
        public static readonly int[] xpThresholds = { 1, 200, 500, 1400, 2900 };
        static readonly object locker = new object();
        static bool running = true;
        static GameData? gameData = null;


        static void Main()
        {
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.White;

            // Check if directory exists
            if (!Directory.Exists(PROJECT_ROOT))
            {
                Directory.CreateDirectory(PROJECT_ROOT);
            }

            // Check if save file exists
            if (File.Exists(SAVE_FILE))
            {
                var savedFileJsonString = File.ReadAllText(SAVE_FILE);
                gameData = JsonSerializer.Deserialize<GameData>(savedFileJsonString);
                Console.WriteLine("Found Saved Data, Restoring...");

                // TODO:Restore data if saved
            }
            else
            {
                gameData = new GameData();
                Console.WriteLine("No Saved Data Found, Starting a new Game...");
            }

            Thread.Sleep(2000);

            while (running)
            {
                MainMenu();
            }
        }
        static void MainMenu()
        {
            Console.Clear();
            Console.Write(@"
Welcome to Dragon CLI Game
---------------------------
1. Book of Dragons
2. Feed Dragons
3. Breed Dragons
4. Hatch Eggs
5. Visit Shop
6. Manage Farms
7. Manage Habitats
8. Save and Exit

Choice> ");
            string? choice = Console.ReadLine()?.Trim();

            switch (choice)
            {
                case "1":
                    ViewDragons();
                    break;
                case "2":
                    ViewFeedDragons();
                    break;
                case "3":
                    ViewBreedingCave();
                    break;
                case "4":
                    ViewHatchery();
                    break;
                case "5":
                    ViewStore();
                    break;
                case "6":
                    ViewFarms();
                    break;
                case "7":
                    ViewHabitats();
                    break;
            }

        }

        static void ViewDragons()
        {
            bool viewing = true;
            while (viewing)
            {
                Console.Clear();
                Console.WriteLine(@"
Dragon Book
-------------------------
");

                foreach (var dragon in gameData.Dragons)
                {
                    Console.Write("In construction...");
                    Console.Write("[B] Back \n Choice> ");
                    string? choice = Console.ReadLine()?.Trim().ToLower();
                    switch (choice)
                    {
                        case "b":
                            viewing = false;
                            break;
                        default:
                            Console.Write("Invalid, Choice> ");
                            Console.ReadKey();
                            break;
                    }


                }

            }
        }

        static void ViewStore()
        {
            bool viewing = true;
            while (viewing)
            {
                Console.Clear();
                Console.Write(@"
Store
-------------------------
");
                Console.Write($"GOLD: {gameData.Gold}g");
                Console.Write(@"
[1...] Selection
[B] Back
-------------------------
1. Eggs
2. Habitats
3. Farms (100g)

Choice> ");
                string? choice = Console.ReadLine()?.Trim();
                switch (choice)
                {
                    case "1":
                        ViewEggStore();
                        break;
                    case "2":
                        ViewHabitatStore();
                        break;
                    case "3":
                        if(gameData.Gold > 100)
                        {
                            var farm = new Farm();
                            Console.WriteLine($"You Purchased a new Farm! Press any key to exit.");
                            gameData.Farms.Add(farm);
                            gameData.Gold -= 100;
                            Console.ReadKey();
                        }
                        break;
                    case "b":
                        viewing = false;
                        break;
                    default:
                        break;
                }

            }
        }

        static void ViewEggStore()
        {
            Dictionary<string, int> availableEggs = new(){
                { "Earth", 100},
                { "Fire", 100},
                { "Water", 350}
            };
            if (gameData.Level >= 5) availableEggs.Add("Nature", 1000);
            if (gameData.Level >= 8) availableEggs.Add("Electric", 4500);
            if (gameData.Level >= 10) availableEggs.Add("Ice", 15000);
            if (gameData.Level >= 15) availableEggs.Add("Metal", 60000);
            if (gameData.Level >= 18) availableEggs.Add("Dark", 120000);
            bool viewing = true;
            while (viewing)
            {
                Console.Clear();
                Console.Write(@"
Egg Store
-------------------------
");
                Console.Write($"GOLD: {gameData.Gold}g");
                Console.Write(@"
[1...] Selection
[B] Back
-------------------------
");
                for (int i = 0; i < availableEggs.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {availableEggs.ElementAt(i).Key} Dragon Egg ({availableEggs.ElementAt(i).Value}g)");
                }

                Console.Write("\nChoice> ");

                string choice = Console.ReadLine()?.Trim().ToLower();

                if(choice == "b")
                {
                    viewing = false;
                    break;
                }

                if(int.TryParse(choice, out int position))
                {
                    if (position > 0 && position < availableEggs.Count + 1)
                    {
                        var eggFactories = new Dictionary<string, Func<Egg>>
                        {
                            { "Earth", () => new EarthEgg() },
                            { "Fire",  () => new FireEgg() }
                            // Add more if needed
                        };

                        string eggString = availableEggs.ElementAt(position - 1).Key;

                        if (eggFactories.TryGetValue(eggString, out var createEgg))
                        {
                            Egg egg = createEgg();

                            if(gameData.UserHatchery.Eggs.Count >= 3)
                            {
                                Console.WriteLine("Hatchery is full! Try to hatch some eggs first... Press any key to continue.");
                                Console.ReadKey();
                                break;
                            }
                            if (gameData.Gold >= egg.Cost)
                            {
                                gameData.Gold -= egg.Cost;
                                gameData.UserHatchery.Eggs.Add(egg);
                                Console.WriteLine($"You purchased: {eggString} Egg for {egg.Cost}g! Press any key to exit.");
                                viewing = false;
                                Console.ReadKey();
                                break;
                            }
                            else
                            {
                                Console.WriteLine($"You do not have enough Gold to purchase the {eggString} Egg. Cost: {egg.Cost}, Your Gold: {gameData.Gold}. Press any key to continue.");
                                Console.ReadKey();
                            }
                        }
                        Console.ReadKey();

                    }

                }
            }
        }

        static void ViewHabitatStore()
        {
            Dictionary<string, HabitatInfo> availableHabitats = new();

            foreach (var kv in AllHabitats)
            {
                string key = kv.Key;
                if ((key == "Earth" || key == "Fire" || key == "Water") ||
                    (gameData.Level >= 5 && key == "Nature") ||
                    (gameData.Level >= 8 && key == "Electric") ||
                    (gameData.Level >= 10 && key == "Ice") ||
                    (gameData.Level >= 15 && key == "Metal") ||
                    (gameData.Level >= 18 && key == "Dark") ||
                    (gameData.Level >= 21 && key == "Legendary") ||
                    (gameData.Level >= 35 && key == "Pure"))
                {
                    availableHabitats[key] = kv.Value;
                }
            }

            bool viewing = true;
            while (viewing)
            {
                Console.Clear();
                Console.Write(@"
Habitat Store
-------------------------");
                Console.Write($"\nGOLD: {gameData.Gold}g");
                Console.Write(@"
[1...] Selection
[B] Back
-------------------------
");

                int idx = 1;
                foreach (var kv in availableHabitats)
                {
                    var info = kv.Value;
                    Console.WriteLine($"{idx++}. {info.DisplayName} Habitat - Cost: {info.Cost} Gold, Build Time: {info.BuildDuration.Humanize(precision: 1)}");
                }

                Console.Write("\nChoice> ");

                string choice = Console.ReadLine()?.Trim().ToLower();

                if(choice == "b")
                {
                    viewing = false;
                    break;
                }
                if (int.TryParse(choice, out int position) && position > 0 && position <= availableHabitats.Count)
                {
                    var selected = availableHabitats.ElementAt(position - 1);
                    var habitatInfo = selected.Value;

                    if (gameData.Gold >= habitatInfo.Cost)
                    {
                        Habitat habitat = habitatInfo.CreateHabitat();
                        habitat.BuildingTime = DateTime.Now.Add(habitatInfo.BuildDuration);
                        gameData.Gold -= habitatInfo.Cost;
                        gameData.Habitats.Add(habitat);
                        Console.WriteLine($"You Purchased: {habitatInfo.DisplayName} Habitat (Ready in {habitatInfo.BuildDuration.Humanize(precision: 1)}). Press any key to continue.");
                        viewing = false;
                    }
                    else
                    {
                        Console.WriteLine($"Not enough gold. You need {habitatInfo.Cost}, but have {gameData.Gold}. Press any key.");
                    }

                    Console.ReadKey();
                }
            }
        }

        static void ViewHatchery()
        {
            bool viewing = true;
            while (viewing)
            {
                Console.Clear();
                Console.Write(@"
Hatchery
-------------------------
[1...] Try to hatch this egg
[B] Back
[Any Key] Refresh
-------------------------
");
                for(int i = 0; i < gameData.UserHatchery.Eggs.Count; i++)
                {
                    Egg egg = gameData.UserHatchery.Eggs[i];
                    TimeSpan timeLeft = egg.HatchingTime - DateTime.Now;
                    string hatchStatus = (timeLeft.TotalSeconds <= 0) ? "HATCHED!" : timeLeft.Humanize(maxUnit: TimeUnit.Hour, minUnit: TimeUnit.Second, precision: 3);
                    Console.WriteLine($"{i + 1}. {egg.DragonName} ({hatchStatus})");
                }

                Console.Write("Choice> ");
                string? choice = Console.ReadLine()?.Trim().ToLower();

                if (choice == "b")
                {
                    viewing = false;
                    break;
                }

                if (int.TryParse(choice, out int position))
                {
                    if(position > 0 && position < gameData.UserHatchery.Eggs.Count + 1)
                    {
                        Egg egg = gameData.UserHatchery.Eggs[position - 1];
                        if (egg.HatchingTime < DateTime.Now)
                        {
                            PlaceEggInHabitat(egg);
                        }
                        else
                        {
                            Console.WriteLine("Egg has not hatched yet! Press any key to continue.");
                            Console.ReadKey();
                        }
                    }
                }
            }
        }
        static void PlaceEggInHabitat(Egg egg)
        {
            var compatibleHabitats = new C5.HashedLinkedList<Habitat>();
            bool viewing = true;
            while (viewing)
            {
                Console.Clear();
                Console.WriteLine(@"
Place egg (only valid habitat showing)
---------------------------------------------------
[1...] Selection
[B] Back
");
                foreach (var element in egg.Elements)
                {
                    foreach (var habitat in gameData.Habitats)
                    {
                        if (habitat.AllowedElements.Contains(element) && habitat.Occupants.Count < habitat.MaxCapacity && (habitat.BuildingTime is null))
                        {
                            compatibleHabitats.Add(habitat);
                        }
                    }
                }

                for (int i = 0; i < compatibleHabitats.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {compatibleHabitats[i].Name} Habitat ({compatibleHabitats[i].Occupants.Count}/{compatibleHabitats[i].MaxCapacity})");
                }

                Console.Write("Choice> ");

                string? choice = Console.ReadLine()?.Trim().ToLower();

                if(choice == "b")
                {
                    viewing = false;
                    break;
                }

                if(int.TryParse(choice, out int position))
                {
                    if (position > 0 && position < compatibleHabitats.Count + 1) 
                    {
                        Console.Write("Please Give this Dragon a name (leave empty for random)> ");
                        string name = Console.ReadLine()?.Trim().ToLower();
                        gameData.UserHatchery.Eggs.Remove(egg);
                        Dragon dragon = egg.Hatch((name.Length > 0) ? name : Dragon.GetRandomName());
                        compatibleHabitats.ElementAt(position - 1).Occupants.Add(dragon);
                        gameData.Dragons.Add(dragon);
                        gameData.CurrentXP += egg.HatchXP;
                        CheckLevel();
                        Console.WriteLine("You have placed this egg! Press any key to exit.");
                        viewing = false;
                    } else
                    {
                        Console.WriteLine("Invalid Number. Try again");
                    }
                    Console.ReadKey();
                    break;
                }
            }
        }
        public static void ViewFarms()
        {
            bool viewing = true;
            while (viewing)
            {
                Console.Clear();
                Console.Write(@"
Manage Farms
-------------------------------");
                Console.Write($"\nFOOD: {gameData.Food}f");
                Console.Write(@"
[1...] To Pick Up or Grow
[Upgrade 1...] To Upgrade Farm
[B] To Back
[Any Key] Refresh
-------------------------------
");
                for(int i = 0; i < gameData.Farms.Count; i++)
                {
                    string producingLine;

                    Crop? crop = gameData.Farms[i].CurrentCrop;
                    var due = gameData.Farms[i].DueDateTime;

                    if (crop is null || due is null)
                    {
                        producingLine = "[AVAILABLE]";
                    }
                    else if (due.Value <= DateTime.Now)
                    {
                        producingLine = "[DONE]";
                    }
                    else
                    {
                        TimeSpan diff = due.Value - DateTime.Now;
                        producingLine = $"[PRODUCING {crop.Name}, Due In: {diff.Humanize(minUnit: TimeUnit.Second, maxUnit: TimeUnit.Hour, precision: 3)}]";
                    }
                    Console.WriteLine($"{i+1}. {gameData.Farms[i].FarmType} {producingLine}");
                }

                Console.Write("\nChoice> ");
                string choice = Console.ReadLine()?.Trim().ToLower();

                if (choice == "b")
                {
                    viewing = false;
                    break;
                }

                if (choice.StartsWith("upgrade"))
                {
                    if (int.TryParse(choice.Substring(8), out int inner_position))
                    {
                        if (inner_position > 0 && inner_position < gameData.Farms.Count + 1)
                        {
                            if (!(gameData.Farms[inner_position - 1].Upgrade(ref gameData)))
                            {
                                Console.WriteLine("You do not have enough Gold to upgrade this farm. Press any key to continue.");
                            }
                            Console.ReadKey();
                        }
                    }
                }

                if (int.TryParse(choice, out int position))
                {
                    var farm = gameData.Farms[position - 1];
                    if (farm.CurrentCrop is null)
                    {
                        // Farm is Available
                        GrowCrop(farm);
                    }
                    else
                    {
                        //First Check if Growing is done, if so, pickup the food.
                        if (farm.DueDateTime < DateTime.Now)
                        {
                            gameData.Food += farm.CurrentCrop.FoodAmount;
                            gameData.CurrentXP += farm.CurrentCrop.XPAmount;
                            CheckLevel();
                            Console.WriteLine($"Picked up {farm.CurrentCrop.FoodAmount}f Gained {farm.CurrentCrop.XPAmount} XP. Press any key to continue");
                            farm.CurrentCrop = null;
                            farm.DueDateTime = null;
                            Console.ReadKey();

                        }
                        else
                        {
                            Console.WriteLine("Farm is not done producing! Press any key to continue.");
                            Console.ReadKey();
                        }
                    }
                }
            }
        }
        public static void GrowCrop(Farm farm)
        {
            bool viewing = true;
            while (viewing)
            {
                Console.Clear();
                Console.WriteLine(@"
Select Crop to Grow
---------------------------------
[1...] To Select
[B] To Back
---------------------------------
");
                Console.WriteLine($"GOLD: {gameData.Gold}");
                for (int i = 0; i < farm.AvailableCrops.Count; i++)
                {
                    Crop crop = farm.AvailableCrops[i];
                    Console.WriteLine($"{i + 1}. {crop.Name} ({crop.Cost}g) [{crop.FoodAmount}f] in {crop.Duration.Humanize(minUnit: TimeUnit.Second, maxUnit: TimeUnit.Hour, precision: 3)}, Earn {crop.XPAmount} XP");
                }

                Console.Write("\nChoice> ");
                string choice = Console.ReadLine()?.Trim();

                if (choice == "b")
                {
                    viewing = false;
                    break;
                }

                if (int.TryParse(choice, out int position))
                {
                    if(gameData.Gold >= farm.AvailableCrops[position - 1].Cost)
                    {
                        gameData.Gold -= farm.AvailableCrops[position - 1].Cost;
                        farm.CurrentCrop = farm.AvailableCrops[position - 1];
                        farm.DueDateTime = DateTime.Now + farm.AvailableCrops[position - 1].Duration;
                        Console.Write("This crop has started producing. Press any key to continue.");
                        viewing = false;
                        Console.ReadKey();
                    } else
                    {
                        Console.Write("You don't have enough Gold to grow this crop. Press any key to continue.");
                        Console.ReadKey();
                    }
                }
            }
        }
        public static void ViewFeedDragons()
        {
            bool viewing = true;
            while (viewing)
            {
                Console.Clear();
                Console.Write(@"
Feed Dragons
-----------------------------");
                Console.WriteLine($"\nFOOD: {gameData.Food}");
                Console.Write(@"
[1...] Feed (FoodPerClick) to Dragon
[B] Back
-----------------------------
");
                int index = 0;
                List<Dragon> indexedDragons = [];
                foreach (var habitat in gameData.Habitats)
                {
                    foreach (var dragon in habitat.Occupants)
                    {
                        indexedDragons.Add(dragon);
                        if(dragon.Level < 20)
                        {
                            Console.WriteLine($"{index + 1}. {dragon.Name} - {dragon.FormalName} [lvl {dragon.Level}] ({dragon.FoodLevel}/{dragon.FoodLevelMax}) +{dragon.FoodPerPress}");
                        } else
                        {
                            Console.WriteLine($"{index + 1}. {dragon.Name} - {dragon.FormalName} [lvl 20] (MAX)");
                        }
                            index++;
                    }
                }

                Console.Write("\nChoice> ");
                string choice = Console.ReadLine()?.Trim().ToLower();

                if (choice == "b")
                {
                    viewing = false;
                    break;
                }

                if (int.TryParse(choice, out int position))
                {
                    if(position > 0 && position < indexedDragons.Count + 1)
                    {
                        var dragon = indexedDragons[position - 1];
                        if (gameData.Food >= dragon.FoodPerPress)
                        {
                            if(dragon.Level < 20)
                            {
                                dragon.Feed();
                                gameData.Food -= dragon.FoodPerPress;
                                Console.WriteLine("Dragon Fed! Press any key to continue");
                                Console.ReadKey();
                            }

                        }
                        else
                        {
                            Console.WriteLine("Not Enough Food to Feed this Dragon! Press any key to continue.");
                            Console.ReadKey();

                        }
                    }
                }
            }
        }
        public static void ViewHabitats()
        {
            bool viewing = true;
            while (viewing)
            {
                Console.Clear();
                Console.Write(@"
Manage Habitats
------------------------------------------
[1...] Update or Collect Build/Update XP
[C] Collect all Gold.
[B] Back
[Any Key] Refresh
------------------------------------------
");
                for(int i = 0; i < gameData.Habitats.Count; i++)
                {
                    Habitat habitat = gameData.Habitats[i];
                    TimeSpan timeSinceLastCollected = habitat.GoldLastCollected.HasValue
                    ? DateTime.Now - habitat.GoldLastCollected.Value
                    : TimeSpan.Zero;

                    int minutes = Convert.ToInt32(timeSinceLastCollected.TotalMinutes);
                    int totalGold = 0;
                    foreach (var dragon in habitat.Occupants)
                    {
                        totalGold += minutes * dragon.GoldRate;
                    }
                    if (totalGold > habitat.MaxGoldCapacity)
                    {
                        habitat.Gold = habitat.MaxGoldCapacity;
                    } else
                    {
                        habitat.Gold = totalGold;
                    }
                    // Habitat is being built.
                    if((habitat.BuildingTime is not null) && (habitat.Level == 1))
                    {
                        var remainingTime = habitat.BuildingTime - DateTime.Now;
                        if(remainingTime.Value.TotalSeconds <= 0)
                        {
                            Console.WriteLine($"{i + 1}. {habitat.Name} Habitat. (DONE BUILDING)");
                        } else
                        {
                            Console.WriteLine($"{i + 1}. {habitat.Name} Habitat. (Building... {remainingTime.Value.Humanize(maxUnit: TimeUnit.Hour, minUnit: TimeUnit.Second, precision: 3)})");
                        }
                    } 
                    //Habitat is being updated.
                    else if((habitat.BuildingTime is not null) && (habitat.Level == 2))
                    {
                        var remainingTime = habitat.BuildingTime - DateTime.Now;
                        if(remainingTime.Value.TotalSeconds <= 0)
                        {
                            Console.WriteLine($"{i + 1}. {habitat.Name} Habitat. (DONE UPGRADING)");
                        } else
                        {
                            Console.WriteLine($"{i + 1}. {habitat.Name} Habitat. (Updating... {remainingTime.Value.Humanize(maxUnit: TimeUnit.Hour, minUnit: TimeUnit.Second, precision: 3)})");
                        }

                    } else
                    {
                        Console.WriteLine($"{i + 1}. {habitat.Name} Habitat. ({habitat.Occupants.Count}/{habitat.MaxCapacity}) - GOLD: ({habitat.Gold}/{habitat.MaxGoldCapacity})");
                    }
                }
                Console.Write("\nChoice> ");
                string choice = Console.ReadLine()?.Trim().ToLower();

                if(choice == "b")
                {
                    viewing = false;
                    break;
                }

                if(choice == "c")
                {
                    int gold = 0;
                    foreach(var habitat in gameData.Habitats)
                    {
                        gold += habitat.RetrieveGold();
                    }
                    Console.WriteLine($"{gold} has been collected! Press any key to continue.");
                    Console.ReadKey();
                }

                if (int.TryParse(choice, out int position))
                {
                    if(position > 0 && position < gameData.Habitats.Count + 1)
                    {
                        // Check if habitat is done updating to collect XP
                        Habitat habitat = gameData.Habitats[position - 1];
                        if(habitat.BuildingTime is not null)
                        {
                            // Not null, so either built or building
                            if(habitat.BuildingTime <= DateTime.Now)
                            {
                                // Is done building
                                switch (habitat.Level)
                                {
                                    case 1:
                                        gameData.CurrentXP += AllHabitats[habitat.Name].BuildXP;
                                        CheckLevel();
                                        Console.WriteLine($"You collected {AllHabitats[habitat.Name].BuildXP} XP! Press any key to continue.");
                                        break;
                                    case 2:
                                        gameData.CurrentXP += AllHabitats[habitat.Name].UpdateXP;
                                        CheckLevel();
                                        Console.WriteLine($"You collected {AllHabitats[habitat.Name].UpdateXP} XP! Press any key to continue.");
                                        break;
                                }
                                habitat.BuildingTime = null;
                                Console.ReadKey();
                            } else
                            {
                                Console.WriteLine("Habitat is still building/updating... Press any key to continue");
                                Console.ReadKey();
                            }
                        } else
                        {
                            // Due Date is null so Try to upgrade.
                            if(habitat.Level < 2)
                            {
                                // See if user can afford upgrade
                                if(gameData.Gold >= AllHabitats[habitat.Name].UpdateCost)
                                {
                                    habitat.Level = 2;
                                    habitat.BuildingTime = DateTime.Now + AllHabitats[habitat.Name].UpdateDuration;
                                    gameData.Gold -= AllHabitats[habitat.Name].UpdateCost;
                                    Console.WriteLine("Habitat is now upgrading... Press any key to continue.");
                                    Console.ReadKey();
                                }
                            } else
                            {
                                Console.WriteLine("Habitat is Max Level! Press any key to continue.");
                                Console.ReadKey();
                            }
                        }
                    }
                }


            }
        }
        public static void ViewBreedingCave()
        {

            Dragon? dragon1 = null;
            Dragon? dragon2 = null;
            int dragonIndex = 1;

            bool viewing = true;
            while (viewing)
            {
                Console.Clear();
                Console.Write(@"
Breeding Cave
---------------------------
");
                if( (gameData.UserBreedingCave.Dragon1 is not null) && (gameData.UserBreedingCave.Dragon2 is not null))
                {
                    // Display Progress and try to get Egg
                    Console.WriteLine("[P] Try to pick up Egg\n[B] Back");
                    Console.WriteLine("-----------------------------------");
                    TimeSpan timeLeft = gameData.UserBreedingCave.DueDate - DateTime.Now ?? TimeSpan.MinValue;
                    dragon1 = gameData.UserBreedingCave.Dragon1;
                    dragon2 = gameData.UserBreedingCave.Dragon2;
                    Console.WriteLine("Dragons are Breeding: ");
                    Console.Write($"{dragon1.Name} - {dragon1.FormalName}");
                    Console.WriteLine($" & {dragon2.Name} - {dragon2.FormalName}");
                    string breedingMessage = (timeLeft.TotalSeconds >= 0) ? timeLeft.Humanize(minUnit: TimeUnit.Second, maxUnit: TimeUnit.Hour, precision: 3) : "[DONE]";
                    Console.WriteLine($"Due in: {breedingMessage}");
                    Console.Write("Choice>");

                    string choice = Console.ReadLine()?.Trim().ToLower();
                    if(choice == "b")
                    {
                        viewing = false;
                        break;
                    }
                    else if(choice == "p")
                    {
                        if(timeLeft.TotalSeconds <= 0)
                        {
                            if(gameData.UserHatchery.Eggs.Count < 4)
                            {
                                gameData.UserHatchery.Eggs.Add(gameData.UserBreedingCave.BreedOutcome);
                                Console.WriteLine($"A new {gameData.UserBreedingCave.BreedOutcome.DragonName} has been placed in the Hatchery! Press any key to exit."); ;
                                gameData.UserBreedingCave.Dragon1 = null;
                                gameData.UserBreedingCave.Dragon2 = null;
                                gameData.UserBreedingCave.DueDate = null;
                                gameData.UserBreedingCave.BreedOutcome = null;
                                Console.ReadKey();
                                viewing = false;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Hatchery is full! Hatch some eggs first. Press any key to continue.");
                                Console.ReadKey();
                            }
                            
                        }
                        else
                        {
                            Console.WriteLine("Egg is not ready yet! Press any key to continue.");
                            Console.ReadKey();
                        }
                    }
                } else
                {
                    // Select both dragons.
                    Console.WriteLine("[1...] Select Dragon (Only Lvl 4+ Dragons showing)\n[B] Back");
                    Console.WriteLine("---------------------------");
                    if (dragon1 is not null) Console.WriteLine($"Dragon 1: {dragon1.Name} - {dragon1.FormalName}");
                    Console.WriteLine($"Select Dragon {dragonIndex}: ");
                    List<Dragon> validDragons = gameData.Dragons
                    .Where(dragon => dragon.Level >= 4 && (dragon1 == null || dragon != dragon1))
                    .ToList();
                    for (int i = 0; i < validDragons.Count; i++)
                    {
                        Dragon dragon = validDragons[i];
                        Console.Write($"{i + 1}. {dragon.Name} - {dragon.FormalName} Dragon (Lvl {dragon.Level}) [ ");
                        foreach (string element in dragon.Elements)
                        {
                            Console.Write($"{element} ");
                        }
                        Console.WriteLine("]");
                    }

                    Console.Write("\nChoice> ");
                    string choice = Console.ReadLine()?.Trim().ToLower();

                    if (choice == "b")
                    {
                        dragon1 = dragon2 = null;
                        viewing = false;
                        break;
                    }
                    if (int.TryParse(choice, out int position))
                    {
                        if (position > 0 && position < validDragons.Count + 1)
                        {
                            var dragon = validDragons[position - 1];
                            if (dragon1 is null)
                            {
                                dragonIndex++;
                                dragon1 = validDragons[position - 1];
                            } else
                            {
                                // Selecting dragon 2 consult the opposites table to deny otherwise calculate offspring.
                                dragon2 = validDragons[position - 1];
                                dragonIndex++;
                                gameData.UserBreedingCave.Dragon1 = dragon1;
                                gameData.UserBreedingCave.Dragon2 = dragon2;

                                // Pick egg and edit properties
                                gameData.UserBreedingCave.BreedOutcome = Breed(dragon1, dragon2);
                                gameData.UserBreedingCave.DueDate = DateTime.Now + gameData.UserBreedingCave.BreedOutcome.BreedingTime;
                                Console.WriteLine($"Dragons are breeding! Breeding will take: {gameData.UserBreedingCave.BreedOutcome.BreedingTime.Humanize(minUnit:TimeUnit.Second, maxUnit:TimeUnit.Hour, precision:3)}. Press any key to exit");
                                Console.ReadKey();
                            }
                        }
                    }
                }
            }
        }
        public static Egg Breed(Dragon dragon1, Dragon dragon2)
        {
            Random random = new Random();
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
                elements = elements.OrderBy(_ => random.Next()).ToList();
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
                    if (dragon1.Level >= 10 && dragon2.Level >= 10)
                    {
                        BreedSpecially();
                    }
                    else
                    {
                        BreedRegularly();
                    }
                }
            }
            else
            {
                if (dragon1.Level >= 10 && dragon2.Level >= 10)
                {
                    BreedSpecially();
                }
                else
                {
                    BreedRegularly();
                }
            } 
            void BreedSpecially()
            {
                int pick = Convert.ToInt32(random.NextInt64(100));
                if(pick < 75)
                {
                    BreedRegularly();
                } else
                {
                    element1 = dragon1.Elements[random.Next(dragon1.Elements.Count)];
                    element2 = dragon2.Elements[random.Next(dragon2.Elements.Count)];
                    // Check if entry for these elements exists.
                    if(BreedingCave.SpecialBreedingTable.ContainsKey(element1) && BreedingCave.SpecialBreedingTable[element1].ContainsKey(element2))
                    {
                        outcome = BreedingCave.SpecialBreedingTable[element1][element2]();
                    } else
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
        public static void CheckLevel()
        {
            while(gameData.CurrentXP > xpThresholds[gameData.Level - 1])
            {
                Console.WriteLine($"New Level achieved! Level: {++gameData.Level}");
            }
        }

        public static Dictionary<string, HabitatInfo> AllHabitats = new()
        {
            ["Earth"] = new HabitatInfo
            {
                DisplayName = "Terra Habitat",
                Cost = 100,
                BuildDuration = TimeSpan.FromSeconds(10),
                UpdateDuration = TimeSpan.FromSeconds(30),
                BuildXP = 100,
                UpdateXP = 2500,
                UpdateCost = 25000,
                CreateHabitat = () => new EarthHabitat()
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

    }
}