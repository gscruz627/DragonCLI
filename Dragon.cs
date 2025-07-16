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
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public List<string> Elements { get; set; }
        public int Level { get; set; }
        public int GoldRate { get; set; }
        public int FoodLevel { get; set; }
        public int FoodLevelMax { get; set; }
        public int FoodPerPress { get; set; }

        public string FormalName { get; set; }

        public bool IsRare { get; set; }
        public bool IsSpecial {  get; set; }

        public static Dictionary<int, int> FoodTable = new()
        {
            {5,20 },{10,40 }, {20,80},{40,160},
            {80,320 },{160,640},{320,1280},{640,2560},
            {1280,5120 },{1400,5600},{1500,6000},{1600,6400},
            {1700,6800 },{1800,7200},{1900,7600},{2000,8000},
            {2100,8400 },{2200,8800},{2300,9200}, {0,0}
        };

        public Dragon(string name)
        {
            Name = name;
            FoodLevel = 0;
            FoodLevelMax = 20;
            FoodPerPress = 5;
        }

        public void LevelUp()
        {
            if(this.Level <= 19)
            {
                this.FoodLevel = 0;
                this.FoodPerPress = FoodTable.ElementAt(Level).Key;
                this.FoodLevelMax = FoodTable.ElementAt(Level).Value;
                this.Level += 1;
                this.GoldRate *= 2;
            }
        }


        public void Feed()
        {
            if (this.FoodLevel + FoodPerPress >= this.FoodLevelMax)
            {
                if(this.Level < 20) this.LevelUp();
                return;
            }
            this.FoodLevel += FoodPerPress;
        }

        public static string GetRandomName()
        {
            Random rand = new Random();
            string dragonName = defaultNames[rand.Next(defaultNames.Length)];
            return dragonName;
        }
        public static string[] defaultNames = [
            "Draco", "Sparky", "Flamy", "Rocky", "Aqua", "Zappy", "Frosty", "Leafy",
            "Shadow", "Luma", "Vulko", "Blaze", "Thunder", "Pebbles", "Nimbus",
            "Scorch", "Spike", "Glimmer", "Ember", "Tundra", "Misty", "Ash", "Zephyr", "Bolt", "Luna", "Loche"
        ];
    }
}
