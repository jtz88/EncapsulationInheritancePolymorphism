using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationInheritancePolymorphism
{
    class Dog : Animal
    {
        public bool HasLeash { get; set; }
        public Dog(string name, double weight, int age, string sound, bool hasleash) : base(name, weight, age, sound)
        {
            HasLeash = hasleash;
        }
        public override string Stats() => $"Dog has {Name}, {Weight}, {Age}, {Sound}, {HasLeash}";

        public string Bark() => "WOFFFSSSS!";

    }
}
