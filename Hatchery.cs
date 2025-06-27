using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonCLI
{
    public class Hatchery
    {
        public int Level { get; set; }
        private readonly int MAX_LEVEL = 3;
        public int Capacity { get; set; }
        public int MaxCapacity {  get; set; }
        public List<Egg> Eggs { get; set; }

        public Hatchery()
        {
            Level = 1;
            Capacity = 1;
            Eggs = [];
        }

        public void Upgrade()
        {
            if (Level < MAX_LEVEL)
            {
                Level++;
            } else
            {
                Console.WriteLine("MAX LEVEL REACHED");
            }
        }

    }
}
