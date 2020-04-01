using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationInheritancePolymorphism
{
    internal class Bird : Animal
    {

        public double WingSpan { get; }

        public Bird(string name, double weight, int age, string sound, double wingSpan) : base(name, weight, age, sound)
        {
            WingSpan = wingSpan;
        }

        public override string Stats() => $"{base.Stats()} Bird has, {WingSpan}";

       // public override string Stats() => base.Stats() + "Bird has, " + WingSpan;



        //public Bird()
        //  {

        //  }
        //public Animal CreateAnimal(string name, double weight, int age, string sound)
        //{
        //    return new Animal(name, weight, age, sound);
        //}
    }

    //internal class SomeBird : Bird
    //{
    //    public string Color { get; }

    //    public SomeBird(string name, double weight, int age, string sound, double wingSpan, string color) : base(name, weight, age, sound, wingSpan)
    //    {
    //        Color = color;

    //    }

    //}
}
