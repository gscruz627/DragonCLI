using System.Text.Json;
using System;
using System.IO;

namespace DragonCLI
{
    class Program
    {
        static readonly string PROJECT_ROOT = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "DragonCity");
        static readonly string SAVE_FILE = Path.Combine(PROJECT_ROOT, "data.json");
        public static readonly int[] xpThresholds = { 1, 200, 500, 1400, 2900 };
        static void Main()
        {
            // Check if directory exists
            if (!Directory.Exists(PROJECT_ROOT))
            {
                Directory.CreateDirectory(PROJECT_ROOT);
            }

            // Check if save file exists
            GameData? gameData;
            if (File.Exists(SAVE_FILE))
            {
                var savedFileJsonString = File.ReadAllText(SAVE_FILE);
                gameData = JsonSerializer.Deserialize<GameData>(savedFileJsonString);
                Console.WriteLine("Found Saved Data, Restoring...");

                // Restore data if saved
            }
            else
            {
                gameData = new GameData();
                Console.WriteLine("No Saved Data Found, Starting a new Game...");

            }

            // Replace this with a cool ASCII name
            Thread.Sleep(2000);
            Console.WriteLine("Welcome to Dragon CLI Game\n For Instructions press (i)");
            Thread.Sleep(2000);

            // Define the initial Menu Selection
            MenuSelection currentSelection = MenuSelection.MainMenu;

            // Main Game Loop
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"=== {currentSelection} ===");
                PrintNavigationHelp();

                // Show menu-specific content
                switch (currentSelection)
                {
                    case MenuSelection.Dragons:
                        Console.WriteLine("You are in the Dragons menu.");
                        break;
                    case MenuSelection.Store:
                        Console.WriteLine("You are in the Store.");
                        break;
                    case MenuSelection.Hatchery:
                        Console.WriteLine("Welcome to the Hatchery.");
                        break;
                    case MenuSelection.Farms:
                        Console.WriteLine("Farms section loaded.");
                        break;
                    case MenuSelection.Habitats:
                        Console.WriteLine("Viewing habitats.");
                        break;
                    case MenuSelection.Profile:
                        Menu.GetProfile(gameData);
                        break;
                    case MenuSelection.Help:
                        Console.WriteLine("Help/About screen.");
                        break;
                    case MenuSelection.Breeding:
                        Console.WriteLine("This is the Breeding Cave.");
                        break;
                    case MenuSelection.BookOfDragon:
                        Console.WriteLine("This is the Book of Dragons.");
                        break;
                }

                Console.WriteLine("\nPress a menu key to switch sections...");

                // Always allow jumping to any section
                var key = Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.D: currentSelection = MenuSelection.Dragons; break;
                    case ConsoleKey.S: currentSelection = MenuSelection.Store; break;
                    case ConsoleKey.H: currentSelection = MenuSelection.Hatchery; break;
                    case ConsoleKey.F: currentSelection = MenuSelection.Farms; break;
                    case ConsoleKey.T: currentSelection = MenuSelection.Habitats; break;
                    case ConsoleKey.P: currentSelection = MenuSelection.Profile; break;
                    case ConsoleKey.I: currentSelection = MenuSelection.Help; break;
                    case ConsoleKey.B: currentSelection = MenuSelection.Breeding; break;
                    case ConsoleKey.M: currentSelection = MenuSelection.MainMenu; break;
                    case ConsoleKey.L: currentSelection = MenuSelection.BookOfDragon; break;
                }
            }

        }
        static void PrintNavigationHelp()
        {
            Console.WriteLine("[D] Dragons  [S] Store  [H] Hatchery  [F] Farms");
            Console.WriteLine("[T] Habitats  [P] Profile  [I] Info  [B] Breeding  [M] Main Menu");
        }
    }

    enum MenuSelection
    {
        MainMenu,
        Dragons,
        Store,
        Hatchery,
        Farms,
        Habitats,
        Profile,
        Help,
        Breeding,
        BookOfDragon
    }
}