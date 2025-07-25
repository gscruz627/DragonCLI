﻿using DragonCLI.Dragons;
using DragonCLI.Eggs;
using DragonCLI.Habitats;
using Humanizer;
using Humanizer.Localisation;
using Newtonsoft.Json;

namespace DragonCLI
{
    class Program
    {
        static readonly string PROJECT_ROOT = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "DragonCity");
        static readonly string SAVE_FILENAME = Path.Combine(PROJECT_ROOT, "data.json");
        static bool running = true;
        static GameData gameData;

        static void Main()
        {

            // Check if directory exists
            if (!Directory.Exists(PROJECT_ROOT))
            {
                Directory.CreateDirectory(PROJECT_ROOT);
            }

            // Check if save file exists
            if (File.Exists(SAVE_FILENAME))
            {
                //Configure Serializer & Deserialize data into a GameData instance.
                var settings = new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.Auto
                };
                string json = File.ReadAllText(SAVE_FILENAME);
                gameData = JsonConvert.DeserializeObject<GameData>(json, settings);
                Console.WriteLine("Found Saved Data, Restoring...");
            }
            else
            {
                // Create new GameData and give the user a beginner habitat and dragon.
                gameData = new GameData();
                gameData.InitializeNewGame();
                Dragon initialDragon = new EarthDragon(Dragon.GetRandomName());
                gameData.Dragons = [initialDragon];
                Habitat initialHabitat = EarthHabitat.CreateDefault();
                initialHabitat.Occupants.Add(initialDragon.Id);
                gameData.Habitats = [initialHabitat];
                Console.WriteLine("No Saved Data Found, Starting a new Game...");
            }

            // Start the main method
            Thread.Sleep(2000);
            while (running)
            {
                MainMenu();
            }
        }
        static void MainMenu()
        {
            // Display menu and let user make a choice
            Console.Clear(); Console.WriteLine("\x1b[3J");
            Console.WriteLine("Welcome to Dragon CLI Game");
            Console.WriteLine("---------------------------");
            Console.WriteLine(gameData.Level < 50
                ? $"LVL {gameData.Level} ({gameData.CurrentXP}/{Helper.xpThresholds[gameData.Level - 1]} xp)"
                : $"LVL {gameData.Level}");
            Helper.WriteLineColored($"GOLD: {gameData.Gold}g", ConsoleColor.Yellow);
            Helper.WriteLineColored($"FOOD: {gameData.Food}f", ConsoleColor.Red);
            Console.WriteLine("---------------------------");
            Console.WriteLine("1. Book of Dragons");
            Console.WriteLine("2. Feed Dragons");
            Console.WriteLine("3. Breed Dragons");
            Console.WriteLine("4. Hatch Eggs");
            Console.WriteLine("5. Visit Shop");
            Console.WriteLine("6. Manage Farms");
            Console.WriteLine("7. Manage Habitats");
            Console.WriteLine("8. Save and Exit");
            Console.Write("Choice> ");
            string choice = Console.ReadLine()?.Trim();

            switch (choice)
            {
                case "1": ViewDragons(); break;
                case "2": ViewFeedDragons(); break;
                case "3": ViewBreedingCave(); break;
                case "4": ViewHatchery(); break;
                case "5": ViewStore(); break;
                case "6": ViewFarms(); break;
                case "7": ViewHabitats(); break;
                case "8": SaveAndExit(); break;
            }
        }

        static void ViewDragons()
        {
            while (true)
            {
                // Display the Book of Dragons, a list of all dragons and whether the user has unlocked them.
                Console.Clear(); Console.WriteLine("\x1b[3J");;
                Console.WriteLine("Book of Dragons");
                Console.WriteLine("--------------------");
                Console.WriteLine("[Any Key] Back");
                Console.WriteLine("--------------------");
                Console.WriteLine("Dragons marked [S] are Special dragons: You need both parents to be Lvl 10+ when breeding to get a small chance at obtaining");
                Console.WriteLine("Dragons marked [R] are Rare dragons: You cannot breed elemental dragons and must breed indirectly foor a small chance at obtaining");
                Console.WriteLine("To obtain Legendary dragons breed two rare dragons for a small chance of obtaining one.\n");
                Console.WriteLine($"Dragons Discovered: {gameData?.DiscoveredDragons.Values.Count((value) => value is true)}/{gameData?.DiscoveredDragons.Count}\n");
                var dragonType = typeof(Dragon);

                // These contains all types that extend the Dragon abstract class
                var allDragonTypes = AppDomain.CurrentDomain.GetAssemblies().SelectMany(asm => asm.GetTypes()).Where(t => !t.IsAbstract && dragonType.IsAssignableFrom(t));
                
                //var allNames = gameData?.DiscoveredDragons.Keys.ToList();
                int i = 0;

                // For each dragon if discovered mark [X] otherwise mark [ ] mark if special or rare.
                foreach(var type in allDragonTypes)
                {
                    var instance = (Dragon)Activator.CreateInstance(type, "");
                    bool discovered = gameData?.DiscoveredDragons[instance.FormalName] ?? false;
                    string status = discovered ? "[X]" : "[ ]";
                    
                    Console.Write($"{status} {i + 1}. {instance.FormalName} [ ");
                    foreach(string element in instance.Elements)
                    {
                        Helper.WriteColored($"{element} ", Helper.ElementToColor[element]);
                    }
                    Console.Write("]");
                    if (instance.IsSpecial) Console.WriteLine(" [S]");
                    else if (instance.IsRare) Console.WriteLine(" [R]");
                    else Console.WriteLine();
                    i++;
                }
                Console.ReadKey(); break;
            }
        }

        static void ViewStore()
        {
            // get farm limit pass gameData object by read only reference
            int farmsLimit = Helper.GetFarmLimit(in gameData);
            while (true)
            {
                Console.Clear(); Console.WriteLine("\x1b[3J");;
                Console.WriteLine("Store");
                Console.WriteLine("-------------------------");
                Helper.WriteLineColored($"GOLD: {gameData?.Gold}g", ConsoleColor.Yellow);
                Console.WriteLine("[1...] Selection");
                Console.WriteLine("[B] Back");
                Console.WriteLine("-------------------------");
                Console.WriteLine("1. Eggs");
                Console.WriteLine("2. Habitats");
                Console.Write($"3. Farms "); Helper.WriteColored("(100g) ", ConsoleColor.Yellow); Console.WriteLine($"{gameData?.Farms.Count}/{farmsLimit}");
                Console.Write("Choice> ");
                string choice = Console.ReadLine()?.Trim().ToLower();
                switch (choice)
                {
                    case "1": ViewEggStore(); break; 
                    case "2": ViewHabitatStore(); break;
                    case "3": 
                        if(gameData?.Gold >= 100) 
                        {
                            if(gameData.Farms.Count < farmsLimit)
                            {
                                var farm = new Farm();
                                farm.AvailableCrops = Farm.InitialFarmConfiguration();
                                Helper.WriteLineColored($"You Purchased a new Farm! Press any key to exit.", ConsoleColor.Green);
                                gameData.Farms.Add(farm); gameData.Gold -= 100; gameData.CurrentXP += 100; CheckLevel();
                                Console.ReadKey(); break;
                            }
                            Helper.WriteLineColored("You cannot purchase more farms at the moment! Level up first! Press any key to continue", ConsoleColor.DarkRed);
                            Console.ReadKey(); break;
                        }
                        Helper.WriteLineColored("You don't have enough gold to purchase a farm! Press any key to continue", ConsoleColor.DarkRed);
                        Console.ReadKey(); break;
                    case "b": break;
                }
            }
        }

        static void ViewEggStore()
        {
            Dictionary<string, int> availableEggs = Helper.GetAvailableEggs(in gameData);
            while (true)
            {
                Console.Clear(); Console.WriteLine("\x1b[3J");;
                Console.WriteLine("Egg Store");
                Console.WriteLine("-------------------------");
                Helper.WriteLineColored($"GOLD: {gameData?.Gold}g", ConsoleColor.Yellow);
                Console.WriteLine("[1...] Selection");
                Console.WriteLine("[B] Back");
                Console.WriteLine("-------------------------");
                for (int i = 0; i < availableEggs.Count; i++)
                {
                    Console.Write($"{i + 1}. {availableEggs.ElementAt(i).Key} Dragon Egg");
                    Helper.WriteLineColored($" ({availableEggs.ElementAt(i).Value}g)", ConsoleColor.Yellow);
                }
                Console.Write("\nChoice> ");
                string choice = Console.ReadLine()?.Trim().ToLower();
                if (choice == "b") break;

                // if position within limits get egg from factory and determine if user is able to purchase
                if(int.TryParse(choice, out int position) && position > 0 && position < availableEggs.Count + 1)
                {
                    string eggString = availableEggs.ElementAt(position - 1).Key;
                    if (Helper.EggFactories.TryGetValue(eggString, out var createEgg))
                    {
                        if (gameData?.UserHatchery.Eggs.Count >= 3)
                        {
                            Helper.WriteLineColored("Hatchery is full! Try to hatch some eggs first... Press any key to continue.", ConsoleColor.DarkRed);
                            Console.ReadKey(); continue;
                        }
                        Egg egg = createEgg();
                        if (gameData?.Gold >= egg.Cost)
                        {
                            gameData.Gold -= egg.Cost;
                            gameData.UserHatchery.Eggs.Add(egg);
                            egg.HatchingTime = DateTime.Now + egg.HatchingDuration;
                            Helper.WriteLineColored($"You purchased: {eggString} Egg for {egg.Cost}g! Press any key to exit.", ConsoleColor.Green);
                            Console.ReadKey(); break;
                        }
                        Helper.WriteLineColored($"You do not have enough Gold to purchase the {eggString} Egg. Cost: {egg.Cost}, Your Gold: {gameData.Gold}. Press any key to continue.", ConsoleColor.DarkRed);
                        Console.ReadKey();
                    }
                }
            }
        }

        static void ViewHabitatStore()
        {
            // get available habitats pass gameData by read only reference
            Dictionary<string, HabitatInfo> availableHabitats = Helper.GetAvailableHabitats(in gameData);
            int habitatLimit = Helper.GetHabitatLimit(in gameData);
            while (true)
            {
                Console.Clear(); Console.WriteLine("\x1b[3J");;
                Console.WriteLine("Habitat Store");
                Console.WriteLine("-------------------------");
                Helper.WriteLineColored($"GOLD: {gameData?.Gold}g - Habitat Count: {gameData?.Habitats.Count}/{habitatLimit}", ConsoleColor.Yellow);
                Console.WriteLine("[1...] Selection");
                Console.WriteLine("[B] Back");
                Console.WriteLine("-------------------------");
                int idx = 1;
                foreach (var kv in availableHabitats)
                {
                    var info = kv.Value;
                    Console.Write($"{idx++}. {info.DisplayName} Habitat - ");
                    Helper.WriteColored($"Cost: {info.Cost} Gold", ConsoleColor.Yellow);
                    Console.WriteLine($", Build Time: {info.BuildDuration.Humanize(maxUnit: TimeUnit.Hour, minUnit: TimeUnit.Second, precision: 3)}");
                }
                Console.Write("\nChoice> ");
                string choice = Console.ReadLine()?.Trim().ToLower();
                if (choice == "b") break;
                if (int.TryParse(choice, out int position) && position > 0 && position <= availableHabitats.Count)
                {
                    var selected = availableHabitats.ElementAt(position - 1);
                    var habitatInfo = selected.Value;
                    if (gameData?.Gold >= habitatInfo.Cost)
                    {
                        if (gameData.Habitats.Count < habitatLimit)
                        {
                            Habitat habitat = habitatInfo.CreateHabitat();
                            habitat.BuildingTime = DateTime.Now.Add(habitatInfo.BuildDuration);
                            gameData.Gold -= habitatInfo.Cost;
                            gameData.Habitats.Add(habitat);
                            Helper.WriteLineColored($"You Purchased: {habitatInfo.DisplayName} Habitat (Ready in {habitatInfo.BuildDuration.Humanize(precision: 1)}). Press any key to continue.", ConsoleColor.Green);
                            Console.ReadKey(); break;
                        }
                        Helper.WriteLineColored("You cannot buy more habitats at this moment. Level up first! Press any key to continue", ConsoleColor.DarkRed);
                        Console.ReadKey(); continue;
                    }
                    Helper.WriteLineColored($"Not enough gold. You need {habitatInfo.Cost}, but have {gameData?.Gold}. Press any key.", ConsoleColor.DarkRed);
                    Console.ReadKey();
                }
            }
        }

        static void ViewHatchery()
        {
            while (true)
            {
                Console.Clear(); Console.WriteLine("\x1b[3J");;
                Console.WriteLine("Hatchery");
                Console.WriteLine("-------------------------");
                Console.WriteLine("[1...] Try to hatch this egg");
                Console.WriteLine("[B] Back");
                Console.WriteLine("[Any Key] Refresh");
                Console.WriteLine("-------------------------");
                // show all eggs display time left to hatch or 'hatched' if hatched.
                for (int i = 0; i < gameData?.UserHatchery.Eggs.Count; i++)
                {
                    Egg egg = gameData.UserHatchery.Eggs[i];
                    TimeSpan timeLeft = egg.HatchingTime - DateTime.Now;
                    string hatchStatus = (timeLeft.TotalSeconds <= 0) ? "HATCHED!" : timeLeft.Humanize(maxUnit: TimeUnit.Hour, minUnit: TimeUnit.Second, precision: 3);
                    string line = $"{i + 1}. {egg.DragonName} ({hatchStatus})";
                    if (hatchStatus == "HATCHED!") Helper.WriteLineColored(line, ConsoleColor.Green);
                    else Console.WriteLine(line);
                }
                Console.Write("Choice> ");
                string choice = Console.ReadLine()?.Trim().ToLower();
                if (choice == "b") break;

                // if position valid determine if egg has hatched and can be placed into a habitat or not.
                if (int.TryParse(choice, out int position) &&
                    position > 0 && position <= gameData?.UserHatchery.Eggs.Count)
                {
                    Egg egg = gameData?.UserHatchery.Eggs[position - 1];
                    if (egg?.HatchingTime <= DateTime.Now) { PlaceEggInHabitat(egg); }
                    else
                    {
                        Helper.WriteLineColored("Egg has not hatched yet! Press any key to continue.", ConsoleColor.DarkRed);
                        Console.ReadKey();
                    }
                }
            }
        }
        static void PlaceEggInHabitat(Egg egg)
        {
            // I used a hashed linked list as a set to avoid duplicates.;
            var compatibleHabitats = new C5.HashedLinkedList<Habitat>();
            while (true)
            {
                Console.Clear(); Console.WriteLine("\x1b[3J");;
                Console.WriteLine("Place egg (only valid habitat showing)");
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("[1...] Selection");
                Console.WriteLine("[B] Back");
                // add to compatible habitats if not null or full and it allows elements that this egg has.
                foreach (var element in egg.Elements)
                {
                    foreach (var habitat in gameData?.Habitats ?? Enumerable.Empty<Habitat>())
                    {
                        if (habitat.AllowedElements == null ||
                            !habitat.AllowedElements.Contains(element) ||
                            habitat.Occupants.Count >= habitat.MaxCapacity ||
                            habitat.BuildingTime is not null)
                        { continue; }
                        compatibleHabitats.Add(habitat);
                    }
                }
                for (int i = 0; i < compatibleHabitats.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {compatibleHabitats[i].Name} Habitat ({compatibleHabitats[i].Occupants.Count}/{compatibleHabitats[i].MaxCapacity})");
                }
                Console.Write("Choice> ");
                string choice = Console.ReadLine()?.Trim().ToLower();
                if(choice == "b") break;

                if (int.TryParse(choice, out int position) && position > 0 && position <= compatibleHabitats.Count)
                {
                // if position within valid limits, remove egg from hatchery, add to specified habitat
                    Console.Write("Please Give this Dragon a name (leave empty for random)> ");
                    string name = Console.ReadLine()?.Trim().ToLower();
                    gameData?.UserHatchery.Eggs.Remove(egg);
                    Dragon dragon = egg.Hatch(!string.IsNullOrEmpty(name) ? name : Dragon.GetRandomName());

                // mark as discovered if not discovered yet, add to general list of dragons and add xp
                    compatibleHabitats[position - 1].Occupants.Add(dragon.Id);
                    if (dragon?.FormalName != null && (gameData?.DiscoveredDragons.ContainsKey(dragon.FormalName) ?? false))
                    { gameData!.DiscoveredDragons[dragon.FormalName] = true; }
                    if (dragon != null) { gameData?.Dragons.Add(dragon); }
                    if (gameData != null) { gameData.CurrentXP += egg.HatchXP; }
                    CheckLevel();
                    Helper.WriteLineColored("You have placed this egg! Press any key to exit.", ConsoleColor.Green);
                    Console.ReadKey(); break;
                }
            }
        }
        public static void ViewFarms()
        {
            while (true)
            {
                Console.Clear(); Console.WriteLine("\x1b[3J");;
                Console.WriteLine("Manage Farms");
                Console.WriteLine("-------------------------------");
                Helper.WriteColored($"GOLD: {gameData?.Gold}g\n", ConsoleColor.Yellow);
                Helper.WriteColored($"FOOD: {gameData?.Food}f\n", ConsoleColor.Red);
                Console.WriteLine("[1...] To Pick Up or Grow");
                Console.WriteLine("[Upgrade 1...] To Upgrade Farm");
                Console.WriteLine("[B] To Back");
                Console.WriteLine("[Any Key] Refresh");
                Console.WriteLine("-------------------------------");

                for (int i = 0; i < gameData?.Farms.Count; i++)
                {
                    // For all farms display whether prooducing or not, a due time and the price for update (if applicable)
                    string producingLine;
                    Crop crop = gameData.Farms[i].CurrentCrop;
                    var due = gameData.Farms[i].DueDateTime;
                    if (crop is null || due is null) { producingLine = "[AVAILABLE]"; }
                    else if (due.Value <= DateTime.Now) { producingLine = "[DONE]"; }
                    else
                    {
                        TimeSpan diff = due.Value - DateTime.Now;
                        producingLine = $"[PRODUCING {crop.Name}, Due In: {diff.Humanize(minUnit: TimeUnit.Second, maxUnit: TimeUnit.Hour, precision: 3)}]";
                    }
                    if(producingLine == "[DONE]")
                    {
                        Helper.WriteColored($"{i + 1}. {gameData.Farms[i].FarmType} {producingLine}", ConsoleColor.Green);
                    } else
                    {
                        Console.Write($"{i + 1}. {gameData.Farms[i].FarmType} {producingLine} ");
                    }
                    switch (gameData.Farms[i].FarmType)
                    {
                        case "Food Farm": Helper.WriteLineColored("UPDATE: 25000g", ConsoleColor.Yellow); break;
                        case "Big Food Farm": Helper.WriteLineColored("UPDATE: 250000g", ConsoleColor.Yellow); break;
                        default: Console.WriteLine(); break;
                    }
                }
                Console.Write("\nChoice> ");
                string choice = Console.ReadLine()?.Trim().ToLower();
                if (choice == "b") break;

                // try to upgrade if within limits
                if (choice?.StartsWith("upgrade") ?? false)
                {
                    if (int.TryParse(choice.AsSpan(8), out int pos) && pos > 0 && pos <= gameData?.Farms.Count)
                    {
                        if (gameData.Farms[pos-1].DueDateTime is not null)
                        {
                            Helper.WriteLineColored("Cannot upgrade this habitat yet! It is producing crops. Press any key to continue", ConsoleColor.DarkRed);
                            Console.ReadKey();
                        } else
                        {
                            //.Upgrade() returns a boolean, the only way to get false is if user does not have enough gold.
                            if (!gameData.Farms[pos - 1].Upgrade(ref gameData))
                                Helper.WriteLineColored("You do not have enough Gold to upgrade this farm. Press any key to continue.", ConsoleColor.DarkRed);
                            Console.ReadKey();
                        }

                    }
                }
                
                // if growing crops within limits try to pick up 
                if (int.TryParse(choice, out int position) && position > 0 && position < gameData?.Farms.Count + 1)
                {
                    var farm = gameData?.Farms[position - 1];
                    if (farm?.CurrentCrop is null) { if (farm is not null) { GrowCrop(farm); } }
                    else
                    {
                        if (farm.DueDateTime < DateTime.Now)
                        {
                            if (gameData is not null)
                            {
                                gameData.Food += farm.CurrentCrop.FoodAmount;
                                gameData.CurrentXP += farm.CurrentCrop.XPAmount;
                            }
                            Helper.WriteLineColored($"Picked up {farm.CurrentCrop.FoodAmount}f Gained {farm.CurrentCrop.XPAmount} XP. Press any key to continue", ConsoleColor.Green);
                            CheckLevel();
                            farm.CurrentCrop = null;
                            farm.DueDateTime = null;
                            Console.ReadKey();
                        }
                        else
                        {
                            Helper.WriteLineColored("Farm is not done producing! Press any key to continue.", ConsoleColor.DarkRed);
                            Console.ReadKey();
                        }
                    }
                }
            }
        }
        public static void GrowCrop(Farm farm)
        {
            while (true)
            {
                Console.Clear(); Console.WriteLine("\x1b[3J");;
                Console.WriteLine("Select Crop to Grow");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("[1...] To Select");
                Console.WriteLine("[B] To Back");
                Console.WriteLine("---------------------------------");
                Helper.WriteLineColored($"GOLD: {gameData?.Gold}", ConsoleColor.Yellow);

                for (int i = 0; i < farm.AvailableCrops.Count; i++)
                {
                    Crop crop = farm.AvailableCrops[i];
                    Console.Write($"{i + 1}. {crop.Name} ");
                    Helper.WriteColored($"({crop.Cost}g) ", ConsoleColor.Yellow);
                    Helper.WriteColored($"[{crop.FoodAmount}f] ", ConsoleColor.Red);
                    Console.Write($"in {crop.Duration.Humanize(minUnit: TimeUnit.Second, maxUnit: TimeUnit.Hour, precision: 3)}, ");
                    Helper.WriteLineColored($"Earn {crop.XPAmount} XP", ConsoleColor.Cyan);
                }
                Console.Write("\nChoice> ");
                string choice = Console.ReadLine()?.Trim();
                if (choice == "b") break;
                // check if selection within limits and start producing the selected crop for this farm.
                if (int.TryParse(choice, out int position) && position > 0 && position < farm.AvailableCrops.Count + 1)
                {
                    if (gameData?.Gold >= farm.AvailableCrops[position - 1].Cost)
                    {
                        gameData.Gold -= farm.AvailableCrops[position - 1].Cost;
                        farm.CurrentCrop = farm.AvailableCrops[position - 1];
                        farm.DueDateTime = DateTime.Now + farm.AvailableCrops[position - 1].Duration;
                        Helper.WriteColored("This crop has started producing. Press any key to continue.", ConsoleColor.Green);
                        Console.ReadKey();
                        break;
                    }
                    Helper.WriteColored("You don't have enough Gold to grow this crop. Press any key to continue.", ConsoleColor.DarkRed);
                    Console.ReadKey();
                }
            }
        }
        public static void ViewFeedDragons()
        {
            while (true)
            {
                Console.Clear(); Console.WriteLine("\x1b[3J");;
                Console.WriteLine("Feed Dragons");
                Console.WriteLine("-----------------------------");
                Helper.WriteLineColored($"FOOD: {gameData?.Food}", ConsoleColor.Red);
                Console.WriteLine("[1...] Feed (FoodPerClick) to Dragon");
                Console.WriteLine("[Remove 1...] Remove this dragon.");
                Console.WriteLine("[B] Back");
                Console.WriteLine("-----------------------------");

                int index = 0;
                // index all dragons
                List<Dragon> indexedDragons = [];
                foreach (var habitat in gameData?.Habitats!)
                {
                    foreach (var dragonId in habitat.Occupants)
                    {
                        Dragon dragon = gameData.Dragons.FirstOrDefault(d => d.Id == dragonId);
                        indexedDragons.Add(dragon);
                        if(dragon.Level < 20)
                        { 
                            Console.Write($"{index + 1}. {dragon.Name} - {dragon.FormalName} [ ");
                            foreach(string element in dragon.Elements)
                            {
                                Helper.WriteColored($"{element} ", Helper.ElementToColor[element]);
                            }
                            Console.Write($"] [lvl {dragon.Level}] ({dragon.FoodLevel}/{dragon.FoodLevelMax})");
                            if (dragon.IsRare)
                            {
                                Helper.WriteColored(" [Rare]", ConsoleColor.Magenta);
                            }
                            Helper.WriteLineColored($" +{dragon.FoodPerPress}\n", ConsoleColor.Red);
                        }
                        else
                        {
                            Console.WriteLine($"{index + 1}. {dragon.Name} - {dragon.FormalName} [lvl 20] (MAX)");
                        }
                        index++;
                    }
                }

                Console.Write("Choice> ");
                string choice = Console.ReadLine()?.Trim().ToLower();

                if (choice == "b") break;

                // check if dragon is not on the breeding cave and remove.
                if (choice.StartsWith("remove"))
                {
                    if (int.TryParse(choice.AsSpan(7), out int pos) && pos > 0 && pos <= indexedDragons.Count)
                    {
                        var dragon = indexedDragons[pos - 1];
                        bool isBreeding = dragon.Id == gameData?.UserBreedingCave.Dragon1?.Id ||
                                          dragon.Id == gameData?.UserBreedingCave.Dragon2?.Id;

                        if (!isBreeding)
                        {
                            foreach (var habitat in gameData?.Habitats ?? Enumerable.Empty<Habitat>())
                                habitat.Occupants.Remove(dragon.Id);
                            gameData?.Dragons.RemoveAll(d => d.Id == dragon.Id);
                            Helper.WriteLineColored("Dragon has been removed! Press any key to continue...", ConsoleColor.DarkYellow);
                        }
                        else
                        {
                            Helper.WriteLineColored("Dragon is on the Breeding Cave right now! It cannot be removed. Press any key to continue.", ConsoleColor.DarkRed);
                        }
                        Console.ReadKey();
                    }
                }

                // try to feed the dragon.
                if(int.TryParse(choice, out int position) && position > 0 && position <= indexedDragons.Count)
                {
                    var dragon = indexedDragons[position - 1];
                    if (gameData?.Food < dragon.FoodPerPress)
                    {
                        Helper.WriteLineColored("Not Enough Food to Feed this Dragon! Press any key to continue.", ConsoleColor.DarkRed);
                    }
                    else if (dragon.Level < 20)
                    {
                        gameData.Food -= dragon.FoodPerPress;
                        dragon.Feed();
                        Helper.WriteLineColored("Dragon Fed! Press any key to continue", ConsoleColor.Green);
                    }
                    Console.ReadKey();
                }
            }
        }
        public static void ViewHabitats()
        {
            while (true)
            {
                Console.Clear(); Console.WriteLine("\x1b[3J");;
                Console.WriteLine("Manage Habitats");
                Console.WriteLine("------------------------------------------");
                Helper.WriteLineColored($"GOLD: {gameData?.Gold}", ConsoleColor.Yellow);
                Console.WriteLine("[1...] Update or Collect Build/Update XP");
                Console.WriteLine("[C] Collect all Gold.");
                Console.WriteLine("[B] Back");
                Console.WriteLine("[Any Key] Refresh");
                Console.WriteLine("------------------------------------------");

                for (int i = 0; i < gameData?.Habitats.Count; i++)
                {
                    // display all habitats, calculate how much gold is there per dragon per habitat.
                    Habitat habitat = gameData.Habitats[i];
                    TimeSpan timeSinceLastCollected = habitat.GoldLastCollected.HasValue
                    ? DateTime.Now - habitat.GoldLastCollected.Value
                    : TimeSpan.Zero;

                    int minutes = Convert.ToInt32(timeSinceLastCollected.TotalMinutes);
                    int totalGold = 0;
                    foreach (var dragonId in habitat.Occupants)
                    {
                        Dragon dragon = gameData.Dragons.FirstOrDefault(d => d.Id == dragonId);
                        totalGold += minutes * dragon.GoldRate;
                    }
                    if (totalGold > habitat.MaxGoldCapacity)
                    {
                        habitat.Gold = habitat.MaxGoldCapacity;
                    } else
                    {
                        habitat.Gold = totalGold;
                    }

                    // habitat is building or upgrading determine if done and print.
                    if((habitat.BuildingTime is not null) && (habitat.Level == 1))
                    {
                        var remainingTime = habitat.BuildingTime - DateTime.Now;
                        if(remainingTime.Value.TotalSeconds <= 0)
                        {
                            Helper.WriteLineColored($"{i + 1}. {habitat.Name} Habitat. (DONE BUILDING)", ConsoleColor.Green);
                        } else
                        {
                            Console.WriteLine($"{i + 1}. {habitat.Name} Habitat. (Building... {remainingTime.Value.Humanize(maxUnit: TimeUnit.Hour, minUnit: TimeUnit.Second, precision: 3)})");
                        }
                    } 
                    else if((habitat.BuildingTime is not null) && (habitat.Level == 2))
                    {
                        var remainingTime = habitat.BuildingTime - DateTime.Now;
                        if(remainingTime.Value.TotalSeconds <= 0)
                        {
                            Helper.WriteLineColored($"{i + 1}. {habitat.Name} Habitat. (DONE UPGRADING)", ConsoleColor.Green);
                        } else
                        {
                            Console.WriteLine($"{i + 1}. {habitat.Name} Habitat. (Updating... {remainingTime.Value.Humanize(maxUnit: TimeUnit.Hour, minUnit: TimeUnit.Second, precision: 3)})");
                        }

                    } else
                    {
                        // if not upgrading display habitat info, and if level 1, price to upgrade.
                        if(habitat.Level == 1)
                        {
                            Console.Write($"{i + 1}. {habitat.Name} Habitat. ({habitat.Occupants.Count}/{habitat.MaxCapacity}) - ");
                            Helper.WriteLineColored($"GOLD: ({habitat.Gold}/{habitat.MaxGoldCapacity}) UPDATE: {Helper.AllHabitats[habitat.Name].UpdateCost}g", ConsoleColor.Yellow);
                        } else
                        {
                            Console.Write($"{i + 1}. {habitat.Name} Habitat. ({habitat.Occupants.Count}/{habitat.MaxCapacity}) - ");
                            Helper.WriteLineColored($"GOLD: ({habitat.Gold}/{habitat.MaxGoldCapacity})", ConsoleColor.Yellow);
                        }
                    }
                }
                Console.Write("\nChoice> ");
                string choice = Console.ReadLine()?.Trim().ToLower();

                if(choice == "b") break;

                if(choice == "c")
                {
                    int gold = 0;
                    foreach(var habitat in gameData.Habitats) { gold += habitat.RetrieveGold(); }
                    Helper.WriteLineColored($"{gold}g has been collected! Press any key to continue.", ConsoleColor.Green);
                    gameData.Gold += gold;
                    Console.ReadKey();
                }

                if (int.TryParse(choice, out int position) && position > 0 && position < gameData.Habitats.Count + 1)
                {
                    var habitat = gameData.Habitats[position - 1];
                    var habitatInfo = Helper.AllHabitats[habitat.Name ?? ""];

                    if (habitat.BuildingTime is not null)
                    {
                        if (habitat.BuildingTime <= DateTime.Now)
                        {
                            int gainedXP = habitat.Level switch
                            {
                                1 => habitatInfo.BuildXP,
                                2 => habitatInfo.UpdateXP,
                                _ => 0
                            };

                            gameData.CurrentXP += gainedXP; CheckLevel();
                            Helper.WriteLineColored($"You collected {gainedXP} XP! Press any key to continue.", ConsoleColor.Green);
                            habitat.BuildingTime = null;
                        }
                        else
                        {
                            Helper.WriteLineColored("Habitat is still building/updating... Press any key to continue.", ConsoleColor.DarkRed);
                        }
                        Console.ReadKey();
                        continue;
                    }
                    if (habitat.Level < 2)
                    {
                        if (gameData.Gold >= habitatInfo.UpdateCost)
                        {
                            habitat.Upgrade();
                            habitat.BuildingTime = DateTime.Now + habitatInfo.UpdateDuration;
                            gameData.Gold -= habitatInfo.UpdateCost;
                            Helper.WriteLineColored("Habitat is now upgrading... Press any key to continue.", ConsoleColor.DarkCyan);
                        }
                        else
                        {
                            Helper.WriteLineColored("You don't have enough gold to upgrade this habitat! Press any key to continue", ConsoleColor.DarkRed);
                        }
                    }
                    else
                    {
                        Helper.WriteLineColored("Habitat is Max Level! Press any key to continue.", ConsoleColor.DarkRed);
                    }
                    Console.ReadKey();
                }
            }
        }
        public static void ViewBreedingCave()
        {
            Dragon dragon1 = null; Dragon dragon2 = null; int dragonIndex = 1;
            while (true)
            {
                Console.Clear(); Console.WriteLine("\x1b[3J");;
                Console.WriteLine("Breeding Cave");
                Console.WriteLine("-----------------------------------");
                if( (gameData?.UserBreedingCave.Dragon1 is not null) && (gameData.UserBreedingCave.Dragon2 is not null))
                {
                    // Display Progress and try to get Egg
                    Console.WriteLine("[P] Try to pick up Egg\n[B] Back");
                    Console.WriteLine("-----------------------------------");
                    TimeSpan timeLeft = gameData.UserBreedingCave.DueDate - DateTime.Now ?? TimeSpan.MinValue;
                    dragon1 = gameData.UserBreedingCave.Dragon1;
                    dragon2 = gameData.UserBreedingCave.Dragon2;
                    Console.WriteLine("Dragons are Breeding: ");
                    Console.WriteLine($"1. {dragon1.Name} - {dragon1.FormalName}");
                    Console.WriteLine($"2. {dragon2.Name} - {dragon2.FormalName}");
                    string breedingMessage = (timeLeft.TotalSeconds >= 0) ? timeLeft.Humanize(minUnit: TimeUnit.Second, maxUnit: TimeUnit.Hour, precision: 3) : "[DONE]";
                    if (breedingMessage == "[DONE]")
                    {
                        Helper.WriteLineColored(breedingMessage, ConsoleColor.Green);
                    } else
                    {
                        Console.WriteLine($"Due in: {breedingMessage}");
                    }
                    Console.Write("Choice>");

                    string choice = Console.ReadLine()?.Trim().ToLower();
                    if(choice == "b") break;

                    // pick up the dragon and empty the breeding cave.
                    else if(choice == "p")
                    {
                        if(timeLeft.TotalSeconds <= 0)
                        {
                            if(gameData.UserHatchery.Eggs.Count < 4)
                            {
                                gameData.UserHatchery.Eggs.Add(gameData?.UserBreedingCave.BreedOutcome ?? new EarthEgg());
                                if (gameData is not null && gameData.UserBreedingCave is not null && gameData.UserBreedingCave.BreedOutcome is not null)
                                {
                                    gameData.UserBreedingCave.BreedOutcome.HatchingTime = DateTime.Now + gameData.UserBreedingCave.BreedOutcome.HatchingDuration;
                                    Helper.WriteLineColored($"A new {gameData?.UserBreedingCave?.BreedOutcome?.DragonName} has been placed in the Hatchery! Press any key to exit.", ConsoleColor.Green);
                                    gameData.UserBreedingCave.Dragon1 = null;
                                    gameData.UserBreedingCave.Dragon2 = null;
                                    gameData.UserBreedingCave.DueDate = null;
                                    gameData.UserBreedingCave.BreedOutcome = null;
                                }
                                Console.ReadKey(); break;
                            }
                            else
                            {
                                Helper.WriteLineColored("Hatchery is full! Hatch some eggs first. Press any key to continue.", ConsoleColor.DarkRed);
                                Console.ReadKey();
                            }
                            
                        }
                        else
                        {
                            Helper.WriteLineColored("Egg is not ready yet! Press any key to continue.", ConsoleColor.DarkRed);
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
                    List<Dragon> validDragons = [.. gameData.Dragons.Where(dragon => dragon.Level >= 4 && (dragon1 == null || dragon.Id != dragon1.Id))];
                    for (int i = 0; i < validDragons.Count; i++)
                    {
                        Dragon dragon = validDragons[i];
                        Console.Write($"{i + 1}. {dragon.Name} - {dragon.FormalName} (Lvl {dragon.Level}) [ ");
                        foreach (string element in dragon.Elements)
                        {
                            Helper.WriteColored($"{element} ", Helper.ElementToColor[element]);
                        }
                        Console.WriteLine("]");
                    }

                    Console.Write("\nChoice> ");
                    string choice = Console.ReadLine()?.Trim().ToLower();

                    if (choice == "b") { dragon1 = dragon2 = null; break; }
                    if (int.TryParse(choice, out int position) && position > 0 && position <= validDragons.Count)
                    {
                        // depending if dragon 1 has already been selected, select dragon
                        var selectedDragon = validDragons[position - 1];
                        if (dragon1 is null)
                        {
                            dragon1 = selectedDragon;
                            dragonIndex++;
                        }
                        else
                        {
                            dragon2 = selectedDragon;
                            dragonIndex++;

                            // dettermine the outcome dragon, and fill in breeding cave information.
                            var outcome = Helper.Breed(dragon1, dragon2);
                            if (outcome is null) { 
                                break; 
                            }

                            gameData.UserBreedingCave.Dragon1 = dragon1;
                            gameData.UserBreedingCave.Dragon2 = dragon2;
                            gameData.UserBreedingCave.BreedOutcome = outcome;
                            gameData.UserBreedingCave.DueDate = DateTime.Now + outcome.BreedingTime;

                            Helper.WriteLineColored($"Dragons are breeding! Breeding will take: {outcome.BreedingTime.Humanize(minUnit: TimeUnit.Second, maxUnit: TimeUnit.Hour, precision: 3)}. Press any key to exit", ConsoleColor.Green);
                            Console.ReadKey();
                        }
                    }

                }
            }
        }
        
        public static void CheckLevel()
        { 
            // this method will check xp after every action that gives xp to the user.
            if(gameData.CurrentXP > Helper.xpThresholds.Last())
            {
                if (gameData.Level == 50) return; // This is not the first time user reaches lvl 50, ignore.
                gameData.Level = 50; gameData.CurrentXP = Helper.xpThresholds.Last();
                Helper.WriteLineColored("You reached Max Level: 50", ConsoleColor.Green);
                return;
            }
            while(gameData.CurrentXP > Helper.xpThresholds[gameData.Level - 1])
            {
                Helper.WriteLineColored($"New Level achieved! Level: {++gameData.Level}", ConsoleColor.DarkCyan);
            }
        }
        public static void SaveAndExit()
        {
            // serialize data and save.
            var options = new Newtonsoft.Json.JsonSerializerSettings
            {
                Formatting = Newtonsoft.Json.Formatting.Indented,
                TypeNameHandling = Newtonsoft.Json.TypeNameHandling.Auto
            };
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(gameData, options);
            File.WriteAllText(SAVE_FILENAME, json);
            Helper.WriteLineColored("Game saved... Press any key to quit the game", ConsoleColor.Green);
            Environment.Exit(0);
        }
    }
}