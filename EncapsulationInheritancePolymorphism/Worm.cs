using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationInheritancePolymorphism
{
    class Worm : Animal
    {
        public bool IsPoisonous { get; set; }
        public Worm(string name, double weight, int age, string sound, bool ispoisonous) : base(name, weight, age, sound)
        {
            IsPoisonous = ispoisonous;
        }
        public override string Stats() => $"Bird has {Name}, {Weight}, {Age}, {Sound}, {IsPoisonous}";
    }
}
