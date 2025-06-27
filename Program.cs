using DragonCLI.Habitats;
using System;
using System.IO;
using System.Text.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;
using DragonCLI.Eggs;
using DragonCLI.Dragons;
using Humanizer;
using Humanizer.Localisation;

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
1. Dragons
2. Feed Dragons
3. Breed Dragons
4. Hatch Eggs
5. Collect Resources
6. Battle Arena
7. Visit Shop
8. Save and Exit

Choice> ");
            string? choice = Console.ReadLine()?.Trim();

            switch (choice)
            {
                case "1":
                    ViewDragons();
                    break;
                case "4":
                    ViewHatchery();
                    break;
                case "7":
                    ViewStore();
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
1. Eggs
2. Habitats
3. Farms
4. Back to Menu

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
                        ViewFarmStore();
                        break;
                    case "4":
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
                Console.WriteLine(@"
Egg Store [B] Back
-------------------------
");
                for (int i = 0; i < availableEggs.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {availableEggs.ElementAt(i).Key} Dragon Egg");
                }

                Console.Write("Choice> ");

                // Add a try catch for non-integers.
                // Instead of { "name" : cost } we will have { "name" : { cost : 
                string choice = Console.ReadLine()?.Trim();
                int choice_number = Convert.ToInt32(choice);
                Egg egg = null;
                if (choice_number > 0 && choice_number <= availableEggs.Count)
                {
                    string eggString = availableEggs.ElementAt(choice_number - 1).Key;
                    switch (eggString)
                    {
                        case "Earth":
                            egg = new EarthEgg();
                            break;
                        case "Fire":
                            egg = new FireEgg();
                            break;

                    }
                    Console.WriteLine($"You Purchased: {eggString} Egg! Press any key to exit.");
                    gameData.UserHatchery.Eggs.Add(egg);
                    viewing = false;
                    Console.ReadKey();
                }
            }
        }

        static void ViewHabitatStore()
        {
            Dictionary<string, int> availableHabitats = new()
            {
                { "Earth", 100 },
                { "Fire", 150 },
                { "Water", 500 },
            };

            if (gameData.Level >= 5) availableHabitats.Add("Nature", 750);
            if (gameData.Level >= 8) availableHabitats.Add("Electric", 3500);
            if (gameData.Level >= 10) availableHabitats.Add("Ice", 75000);
            if (gameData.Level >= 15) availableHabitats.Add("Metal", 200000);
            if (gameData.Level >= 18) availableHabitats.Add("Dark", 350000);

            bool viewing = true;
            while (viewing)
            {
                Console.Clear();
                Console.WriteLine(@"
Habitat Store [B] Back
-------------------------
");
                for (int i = 0; i < availableHabitats.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {availableHabitats.ElementAt(i).Key} Habitat");
                }

                Console.Write("Choice> ");

                string choice = Console.ReadLine()?.Trim();
                int choice_number = Convert.ToInt32(choice);
                Habitat habitat = null;
                if (choice_number > 0 && choice_number <= availableHabitats.Count)
                {
                    string habitatString = availableHabitats.ElementAt(choice_number - 1).Key;
                    switch (habitatString)
                    {
                        case "Earth":
                            habitat = new EarthHabitat();
                            break;
                        case "Fire":
                            habitat = new FireHabitat();
                            break;

                    }
                    Console.WriteLine($"You Purchased: {habitatString} Habitat! Press any key to exit.");
                    gameData.Habitats.Add(habitat);
                    viewing = false;
                    Console.ReadKey();

                }
            }
        }

        static void ViewFarmStore()
        {
            Dictionary<string, int> availableFarms = new()
            {
                { "Food Farm", 100 },
            };

            if (gameData.Level >= 8) availableFarms.Add("Big Food Farm", 25000);
            if (gameData.Level >= 18) availableFarms.Add("Huge Food Farm", 500000);

            bool viewing = true;
            while (viewing)
            {
                Console.Clear();
                Console.WriteLine(@"
Farm Store
-------------------------
");
                for (int i = 0; i < availableFarms.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {availableFarms.ElementAt(i).Key}");
                }

                Console.Write("Choice> ");

                string choice = Console.ReadLine()?.Trim();
                int choice_number = Convert.ToInt32(choice);
                Farm farm = null;
                if (choice_number > 0 && choice_number <= availableFarms.Count)
                {
                    string farmString = availableFarms.ElementAt(choice_number - 1).Key;
                    switch (farmString)
                    {
                        case "Food Farm":
                            //farm = new FoodFarm();
                            break;
                        case "Big Food Farm":
                            //farm = new BigFoodFarm();
                            break;
                        case "Huge Food Farm":
                            //farm = new HugeFoodFarm();
                            break;

                    }
                    Console.WriteLine($"You Purchased: {farmString} ! Press any key to exit.");
                    gameData.Farms.Add(farm);
                    viewing = false;
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
HATCHERY
-------------------------
");
                for(int i = 0; i < gameData.UserHatchery.Eggs.Count; i++)
                {
                    Egg egg = gameData.UserHatchery.Eggs[i];
                    TimeSpan timeLeft = egg.HatchingTime - DateTime.Now;
                    string hatchStatus = (timeLeft.TotalSeconds <= 0) ? "HATCHED!" : timeLeft.Humanize(maxUnit: TimeUnit.Hour, minUnit: TimeUnit.Second, precision: 3);
                    Console.WriteLine($"{i + 1}. {egg.DragonName} ({hatchStatus})");
                }

                Console.Write("choice> ");
                string? choice = Console.ReadLine()?.Trim();

                if (choice.ToLower() == "b")
                {
                    viewing = false;
                    break;
                }

                if (int.TryParse(choice, out int position))
                {
                    Egg egg = gameData.UserHatchery.Eggs[position - 1];
                    if(egg.HatchingTime < DateTime.Now)
                    {
                        PlaceEggInHabitat(egg);
                    } else
                    {
                        Console.WriteLine("Egg has not hatched yet! Press any key to continue.");
                        Console.ReadKey();
                    }
                }
                // LOOP: 1. DRAGON NAME (13 SECONDS)
                // LOOP: 2. DRAGON NAME (23 HOURS, 21 MINUTES, 12 SECONDS)
                // if duedate before right now: hatch possible
                // ask user: b to back, u to update, number to try to hatch -> has not hatched yet, preses any, hatched -> placeInHabitat();
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
PLACE EGG IN HABITAT (only valid habitat showing)
---------------------------------------------------
");
                foreach (var element in egg.Elements)
                {
                    foreach (var habitat in gameData.Habitats)
                    {
                        if (habitat.AllowedElements.Contains(element) && habitat.Occupants.Count < habitat.MaxCapacity)
                        {
                            compatibleHabitats.Add(habitat);
                        }
                    }
                }

                for (int i = 0; i < compatibleHabitats.Count(); i++)
                {
                    Console.WriteLine($"{i + 1}. {compatibleHabitats[i]}");
                }

                Console.Write("choice> ");

                string? choice = Console.ReadLine()?.Trim();

                if(choice == "b")
                {
                    viewing = false;
                    break;
                }

                if(int.TryParse(choice, out int position))
                {
                    if (position > 0 && position < compatibleHabitats.Count + 1) 
                    {
                        gameData.UserHatchery.Eggs.Remove(egg);
                        compatibleHabitats.ElementAt(position - 1);
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
    }

}