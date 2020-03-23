using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationInheritancePolymorphism
{
    class Horse : Animal
    {
        public string Race { get; set; }
        public Horse(string name, double weight, int age, string sound, string race) : base(name, weight, age, sound)
        {
            Race = race;
        }

        public override string Stats() => $"Horse has {Name}, {Weight}, {Age}, {Sound}, {Race}";
    }
}
