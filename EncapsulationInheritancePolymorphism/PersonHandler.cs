using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationInheritancePolymorphism
{
    public class PersonHandler 
    {
        public void SetAge(Gubbe pers, int age)
        {
            pers.Age = age;
        }

        //Metod som returnerar en Person
        public Gubbe CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            //1.
            //Person person = new Person();
            //person.Age = age;
            //Kommer att använda default constructor

            //2.
            //return new Person
            //{
            //    Age =  age,
            //    Fname = fname
            //};
            //Kommer att använda default constructor

            //3.
            return new Gubbe(age, fname, lname, height, weight);
            //Returnerar till en constructor
            
        }

        //Metod som returnerar en Person
        public Gubbe CreatePerson(int age, string fname, string lname)
        {
            return new Gubbe(age, fname, lname);
        }
    }
}
