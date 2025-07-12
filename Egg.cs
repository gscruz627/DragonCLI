using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DragonCLI
{
    public abstract class Egg
    {
        public string DragonName { get; set; }
        public List<string> Elements { get; set; }
        public DateTime HatchingTime { get; set; }
        public TimeSpan HatchingDuration { get; set; }
        public string TargetDragonClassName { get; set; }

        [Newtonsoft.Json.JsonIgnore]
        public Func<string, Dragon> TargetDragon =>
            (name) => CreateDragonInstance(name);
        public TimeSpan BreedingTime { get; set; }
        public int Cost { get; set; }

        public int HatchXP { get; set; }
        public Dragon Hatch(string name)
        {            
            return TargetDragon(name);
        }

        private Dragon CreateDragonInstance(string name)
        {
            if(name is null)
            {
                name = Dragon.GetRandomName();
            }
            var assembly = typeof(Dragon).Assembly;
            var fullName = $"DragonCLI.{TargetDragonClassName}";
            var type = assembly.GetType(fullName);
            return (Dragon)Activator.CreateInstance(type, name);
        }
    }
}
