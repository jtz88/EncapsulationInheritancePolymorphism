using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationInheritancePolymorphism
{
    class Swan : Bird
    {
        public string Color { get; set; }
        public Swan(string name, double weight, int age, string sound, double wingSpan, string color) : base(name, weight, age, sound, wingSpan)
        {
            Color = color;
        }
    }
}
