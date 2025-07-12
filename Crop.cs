using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonCLI
{
    public class Crop(string name, int cost, int foodAmount, TimeSpan duration, int xpamount)
    {
        public string Name { get; set; } = name;
        public int Cost { get; set; } = cost;
        public int FoodAmount { get; set; } = foodAmount;
        public TimeSpan Duration { get; set; } = duration;
        public int XPAmount { get; set; } = xpamount;
    }

}
