using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonCLI
{
    class HabitatInfo
    {
        public Func<Habitat> CreateHabitat { get; set; }
        public string DisplayName { get; set; }
        public int Cost { get; set; }
        public TimeSpan BuildDuration { get; set; }
        public TimeSpan UpdateDuration { get; set; }
        public int BuildXP { get; set; }
        public int UpdateXP { get; set; }
        public int UpdateCost { get; set; }

    }

}
