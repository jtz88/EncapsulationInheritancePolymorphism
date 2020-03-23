using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationInheritancePolymorphism
{
    class Pelican : Bird
    {
        public string Color { get; set; }
        public Pelican(string name, double weight, int age, string sound, double wingSpan, string color) : base(name, weight, age, sound, wingSpan)
        {
            Color = color;
        }
    }
}
