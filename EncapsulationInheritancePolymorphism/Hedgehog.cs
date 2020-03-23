using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationInheritancePolymorphism
{
    class Hedgehog :Animal
    {
        public int NrOfSpikes { get; set; }
        public Hedgehog(string name, double weight, int age, string sound, int nrofspikes) : base(name, weight, age, sound)
        {
            NrOfSpikes = nrofspikes;
        }
        public override string Stats() => $"Bird has {Name}, {Weight}, {Age}, {Sound}, {NrOfSpikes}";

    }
}
