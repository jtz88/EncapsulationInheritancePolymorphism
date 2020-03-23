using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationInheritancePolymorphism
{
    class Animal
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }
        public string Sound { get; set; }


        public Animal(string name, double weight, int age, string sound)
        {
            Name = name;
            Weight = weight;
            Age = age;
            Sound = sound;
        }

        public virtual string Stats() => $"Animals has {Name}, {Weight}, {Age}, {Sound}";
    }
}
