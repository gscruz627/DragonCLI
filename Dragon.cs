using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonCLI
{
    public abstract class Dragon
    {
        public string? Name { get; set; }
        public List<string>? Elements { get; set; }
        public int Level { get; set; }
        public int GoldRate { get; set; }
        /*
         * Food Level varies by level this.Level * 100
         */
        public int FoodLevel { get; set; }
        public int FoodLevelMax { get; set; }

        public string? FormalName { get; set; }

        public List<Attack>? Attacks { get; set; }

        public Dragon(string name)
        {
            Name = name;
        }

        public void LevelUp(int remainder)
        {
            this.FoodLevel = remainder;
            this.FoodLevelMax = 2 * this.FoodLevelMax;
            this.Level += 1;

        }


        public void Feed(int food)
        {
            if (this.FoodLevel + food >= this.FoodLevelMax)
            {
                this.LevelUp((this.FoodLevel + food) - this.FoodLevelMax);
                return;
            }
            this.FoodLevel += food;
        }

        public static string GetRandomName()
        {
            string[] defaultNames = [
                "Draco", "Sparky", "Flamy", "Rocky", "Aqua", "Zappy", "Frosty", "Leafy",
                "Shadow", "Luma", "Vulko", "Blaze", "Thunder", "Pebbles", "Nimbus",
                "Scorch", "Spike", "Glimmer", "Ember", "Tundra", "Misty", "Ash", "Zephyr", "Bolt", "Luna", "Loche"
            ];

            Random rand = new Random();
            string dragonName = defaultNames[rand.Next(defaultNames.Length)];
            return dragonName;
        }
    }
}
