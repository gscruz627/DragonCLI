using DragonCLI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonCLI
{
    public class Menu
    {
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
        public static void DisplayStore(GameData data)
        {
            Dictionary<string, int> availableEggs = new(){
                { "Terra", 100},
                { "Fire",100},
                {"Water",350}
            };

            if (data.Level >= 5) availableEggs.Add("Nature",1000);
            if (data.Level >= 8) availableEggs.Add("Electric",4500);
            if (data.Level >= 10) availableEggs.Add("Ice",15000);
            if (data.Level >= 15) availableEggs.Add("Metal",60000);
            if (data.Level >= 18) availableEggs.Add("Dark",120000);


            while (true)
            {
                Console.Clear();
                Console.WriteLine("[1- ...] Selection [M] Main Menu");
                Console.WriteLine("== Welcome to the Store ==");
                Console.WriteLine("= EGGS =");
                int counter = 1;
                foreach(var egg in availableEggs)
                {
                    Console.WriteLine($"{counter}. {egg.Key} Dragon Egg: {egg.Value}g");
                    counter++;
                }
                var key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.M)
                {
                    return;
                }
                else
                {
                    //Console.Write($"You've selected {availableEggs[Convert.ToInt32(key.KeyChar.ToString()) - 1]} Dragon Egg");
                }
            }
        }
    }
}
