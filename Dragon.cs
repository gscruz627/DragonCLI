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
        public int GoldProduced { get; set; }
        /*
         * Food Level varies by level this.Level * 100
         */
        public int FoodLevel { get; set; }
        public int FoodLevelMax { get; set; }

        public List<Attack>? Attacks { get; set; }

        public void LevelUp(int remainder)
        {
            this.FoodLevel = remainder;
            this.FoodLevelMax = 2 * this.FoodLevelMax;
            this.Level += 1;

        }

        public void Update()
        {
            this.GoldProduced += GoldRate;
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
    }
}
