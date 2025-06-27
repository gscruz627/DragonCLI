using DragonCLI;
using DragonCLI.Eggs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Humanizer;
using Humanizer.Localisation;
using C5;
using DragonCLI.Habitats;

namespace DragonCLI
{
    public class Menu
    {
        /*
        public static void GetProfile(GameData data)
        {
            // Build the content lines
            string title = "PROFILE INFORMATION";
            string levelString = $"Level {data.Level}";
            string xpString = $"XP to Level {data.Level + 1}: {data.CurrentXP}/{Program.xpThresholds[data.Level]}";
            string goldString = $"Gold: {data.Gold}g";
            string foodString = $"Food: {data.Food}f";

            // Put all display lines into a list
            List<string> contentLines =
                [
                    "",
                    title,
                    "",
                    levelString,
                    xpString,
                    goldString,
                    foodString,
                    ""
                ];

            // Determine the max content width
            int maxLength = contentLines.Max(line => line.Length);
            int boxWidth = maxLength + 10; // extra padding for nicer look

            // Build the top border
            string borderTop = "+" + new string('-', boxWidth - 2) + "+";

            // Build all lines with padding
            StringBuilder box = new();
            box.AppendLine(borderTop);
            foreach (string line in contentLines)
            {
                int paddingLeft = 5;
                int paddingRight = boxWidth - 2 - paddingLeft - line.Length;
                box.AppendLine("|" + new string(' ', paddingLeft) + line + new string(' ', paddingRight) + "|");
            }
            box.AppendLine("|" + new string('-', boxWidth - 2) + "|");

            Console.WriteLine(box.ToString());
        }
        public static void DisplayStore(GameData data, object locker, ref MenuSelection currentSelection)
        {
            Dictionary<string, int> availableEggs = new(){
                { "Earth", 100},
                { "Fire", 100},
                { "Water", 350}
            };

            Dictionary<string, int> availableHabitats = new()
            {
                { "Earth", 100 },
                { "Fire", 150 },
                { "Water", 500 },
            };

            Dictionary<string, int> availableFarms = new()
            {
                { "Food Farm", 100 },
            };

            if (data.Level >= 8) availableFarms.Add("Big Food Farm", 25000);
            if (data.Level >= 18) availableFarms.Add("Huge Food Farm", 500000);


            if (data.Level >= 5) availableHabitats.Add("Nature", 750);
            if (data.Level >= 8) availableHabitats.Add("Electric", 3500);
            if (data.Level >= 10) availableHabitats.Add("Ice", 75000);
            if (data.Level >= 15) availableHabitats.Add("Metal", 200000);
            if (data.Level >= 18) availableHabitats.Add("Dark", 350000);
            

            if (data.Level >= 5) availableEggs.Add("Nature",1000);
            if (data.Level >= 8) availableEggs.Add("Electric",4500);
            if (data.Level >= 10) availableEggs.Add("Ice",15000);
            if (data.Level >= 15) availableEggs.Add("Metal",60000);
            if (data.Level >= 18) availableEggs.Add("Dark",120000);
            bool inStore = true;
            string selection = "";
            while (inStore)
            {
                Console.Clear();
                Console.WriteLine($"=== Store Menu ({data.Gold}g) ===");
                int counter = 1;

                lock (locker)
                {
                    Console.WriteLine("\n=== EGGS ===");
                    foreach(var egg in availableEggs)
                    {
                        Console.WriteLine($"{counter}. {egg.Key} Dragon Egg: {egg.Value}g");
                        counter++;
                    }

                    Console.WriteLine("\n=== HABITATS ===");
                    foreach(var habitat in availableHabitats)
                    {
                        Console.WriteLine($"{counter}. {habitat.Key} Habitat: {habitat.Value}g");
                        counter++;
                    }

                    Console.WriteLine("\n=== FARMS ===");
                    foreach(var farm in availableFarms)
                    {
                        Console.WriteLine($"{counter}. {farm.Key}: {farm.Value}");
                    }
                }

                Console.WriteLine($"\nPress [1–{counter}] to buy, or [B] to go back");

                int sleepMs = 100;
                int elapsed = 0;
                int refreshInterval = 1000; // ms

                while (elapsed < refreshInterval)
                {
                    if (Console.KeyAvailable)
                    {
                        var keyInfo = Console.ReadKey(true);
                        if (keyInfo.Key == ConsoleKey.B)
                        {
                            inStore = false;
                            currentSelection = MenuSelection.MainMenu;
                            break;
                        }

                        if (char.IsDigit(keyInfo.KeyChar))
                        {
                            int index = Convert.ToInt32(keyInfo.KeyChar - '0') - 1;
                            lock (locker)
                            {
                                if ( (index+1) < availableEggs.Count)
                                {
                                    // LOGIC FOR PURCHASING EGGS
                                    if (data.UserHatchery.Eggs.Count < data.UserHatchery.Capacity)
                                    {
                                        // Purchase Egg and place in Hatchery
                                        string eggName = availableEggs.ElementAt(index).Key;
                                        if (eggName == "Earth")
                                        {
                                            var egg = new EarthEgg();
                                            data.UserHatchery.Eggs.Add(egg);
                                            currentSelection = MenuSelection.Hatchery;
                                            inStore = false;
                                            break;

                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Capacity Full, Cannot add more eggs right now.");
                                    }
                                }
                                else if ((index+1) < (availableHabitats.Count + availableEggs.Count))
                                {
                                    // LOGIC FOR PURCHASING HABITATS
                                    string habitatString = availableHabitats.ElementAt(index - availableEggs.Count).Key;
                                    Habitat? habitat = null;
                                    if (habitatString == "Earth")
                                    {
                                        habitat = new EarthHabitat();

                                    } else if (habitatString == "Fire")
                                    {
                                        habitat = new FireHabitat();
                                    }
                                    data.Habitats.Add(habitat);
                                    currentSelection = MenuSelection.Hatchery;
                                    inStore = false;
                                    break;

                                }
                                else
                                {
                                    string farmString = availableFarms.ElementAt(index - availableEggs.Count - availableHabitats.Count).Key;
                                    if(farmString == "Food Farm")
                                    {
                                        Console.WriteLine("you purchased food farm");
                                    }
                                }
                                
                            }
                        }
                    }

                    Thread.Sleep(sleepMs);
                    elapsed += sleepMs;
                }
            }
        }
    
        public static void DisplayHabitats(GameData data, object locker, ref MenuSelection currentSelection)
        {
            bool inHabitats = true;
            while (inHabitats)
            {
                Console.Clear();
                Console.WriteLine("=== HABITATS ===");
                Console.WriteLine("Press [▲ - ▼] To Select a Habitat. [B] To Exit");
                int cursor = 0;
                int index = 0;
                lock (locker)
                {
                    foreach (var habitat in data.Habitats)
                    {
                        Console.WriteLine("-------------------------------------------------------------");
                        if (cursor == index)
                        {
                            Console.WriteLine($"> {habitat.Name} [Lvl {habitat.Level}]: {habitat.Gold}");
                        } else
                        {
                            Console.WriteLine($"{habitat.Name} [Lvl {habitat.Level}]: {habitat.Gold}");

                        }
                        Console.WriteLine($"index: {index}, cursor: {cursor}");
                        foreach (var dragon in habitat.Occupants)
                        {
                            Console.WriteLine($"\n({dragon.FormalName}) [{dragon.Level}] {dragon.Name} ");
                        }
                        index++;
                    }
                }
                int sleepMs = 100;
                int elapsed = 0;
                int refreshInterval = 1000; // ms

                while (elapsed < refreshInterval)
                {
                    if (Console.KeyAvailable)
                    {
                        var keyInfo = Console.ReadKey(true);
                        if (keyInfo.Key == ConsoleKey.B)
                        {
                            inHabitats = false;
                            return;
                        }
                        if(keyInfo.Key == ConsoleKey.DownArrow)
                        {
                            if(cursor > 0) cursor--;
                        }
                        if(keyInfo.Key == ConsoleKey.UpArrow)
                        {
                            if(cursor < data.Habitats.Count - 1) { cursor++; }
                        }
                    }
                    Thread.Sleep(sleepMs);
                    elapsed += sleepMs;
                }
            }
        }
    
        public static void DisplayHatchery(GameData data, object locker, ref MenuSelection currentSelection)
        {
            bool inHatchery = true;
            while (inHatchery)
            {
                Console.Clear();
                Console.WriteLine("== HATCHERY ==");
                Console.WriteLine(" Egg (Hatches in...)");
                Console.WriteLine("------------------------------\n");
                int counter = 1;

                lock (locker)
                {
                    foreach(var egg in data.UserHatchery.Eggs)
                    {
                        TimeSpan timeLeft = egg.HatchingTime - DateTime.Now;
                        bool hatched = timeLeft.TotalSeconds <= 0;
                        string hatchStatus = hatched
                        ? "HATCHED"
                        : timeLeft.Humanize(precision: 3, maxUnit: TimeUnit.Hour, minUnit: TimeUnit.Second);
                        Console.WriteLine($"{counter}. {egg.DragonName} ({hatchStatus})");
                    }
                }

                Console.WriteLine($"\nPress [1 - {data.UserHatchery.Eggs.Count}] To Place a hatched egg. [B] To Exit");
                int sleepMs = 100;
                int elapsed = 0;
                int refreshInterval = 1000; // ms

                while (elapsed < refreshInterval)
                {
                    if (Console.KeyAvailable)
                    {
                        var keyInfo = Console.ReadKey(true);
                        if (keyInfo.Key == ConsoleKey.B)
                        {
                            inHatchery = false;
                            currentSelection = MenuSelection.MainMenu;
                            return;

                        }

                        if (char.IsDigit(keyInfo.KeyChar))
                        {
                            int index = Convert.ToInt32(keyInfo.KeyChar - '0') - 1;
                            lock (locker)
                            {
                                // Hatch egg and place into habitat logic.
                                if (data.UserHatchery.Eggs.ElementAt(index).HatchingTime <= DateTime.Now)
                                {
                                    PlaceEggInHabitat(data, index, locker);
                                    currentSelection = MenuSelection.MainMenu;
                                } else
                                {
                                    Console.WriteLine("EGG HAS NOT HATCHED YET.");
                                    
                                }
                            }
                        }
                    }
                    Thread.Sleep(sleepMs);
                    elapsed += sleepMs;
                }
            }
        }

        private static void PlaceEggInHabitat(GameData data, int index, object locker)
        {
            bool inPlaceHabitat = true;
            Egg egg = data.UserHatchery.Eggs.ElementAt(index);
            var compatibleHabitats = new C5.HashedLinkedList<Habitat>();
            while (inPlaceHabitat)
            {

                Console.Clear();
                Console.WriteLine("== PLACE EGG IN HABITAT, CHOOSE HABITAT ==");
                Console.WriteLine("Only those habitat that are not full are shown here: ");

                int count = 1;
                lock (locker)
                {
                    foreach(var element in egg.Elements)
                    {
                        foreach(var habitat in data.Habitats)
                        {
                            if (habitat.AllowedElements.Contains(element) && habitat.Occupants.Count < habitat.MaxCapacity)
                            {
                                Console.WriteLine($"{count}. {habitat.Name}");
                                compatibleHabitats.Add(habitat);
                                count++;
                            }
                        }
                    }
                }

                Console.WriteLine($"\n Press [1.. {compatibleHabitats.Count}] To Select the Habitat. [B] To Exit");
                int sleepMs = 100;
                int elapsed = 0;
                int refreshInterval = 1000; // ms
                
                while (elapsed < refreshInterval)
                {
                    if (Console.KeyAvailable)
                    {
                        var keyInfo = Console.ReadKey(true);
                        if (keyInfo.Key == ConsoleKey.B)
                        {
                            inPlaceHabitat = false;
                            return;
                        }
                        if (char.IsDigit(keyInfo.KeyChar))
                        {
                            int idx = Convert.ToInt32(keyInfo.KeyChar - '0') - 1;
                            lock (locker)
                            {
                                Console.WriteLine("Dragon Name (leave empty for random): ");
                                string? name = Console.ReadLine();
                                if (name.Length == 0) { name = Dragon.GetRandomName(); }
                                var habitat = compatibleHabitats[idx];
                                var dragon = egg.Hatch(name);
                                data.UserHatchery.Eggs.Remove(egg);
                                habitat.Occupants.Add(dragon);
                                inPlaceHabitat = false;
                            }
                        }
                    }
                    Thread.Sleep(sleepMs);
                    elapsed += sleepMs;
                }
            }
        }
        */
    }
}
