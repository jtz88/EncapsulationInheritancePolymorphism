using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationInheritancePolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //Svar 3.2 Fråga 8: I Bird klassen
            //Svar 3.2 Fråga 9: I Animal klassen
            //Svar 3.3 Fråga 7: Horse är inte av samma typ som Dog, men båda är Animal
            //Svar 3.3 Fråga 8: Animal
            //Svar 3.3 Fråga 11: Vid varje foreach iterering så anropas den mest specialiserade metoden för typen 
            //Svar 3.3 Fråga 15: Listan har inte instansierats ännu
            //Svar 3.4 Fråga 11: Polymorphism tillåter oss at göra anrop till metoder i derived klasser genom bas klass referens i runtime. Klasser kan ha olika implementationer av metoder som anropas via samma namn.
            //Svar 3.4 Fråga 13: Abstrakta klasser får innehålla implementering och accessmodifiers, interface får endast innehålla deklarationer och är alltid public

            //Person person = new Person();
            //ph.SetAge(person, 45);
            //Console.WriteLine(person.Age);

            PersonHandler ph = new PersonHandler();
            Person person = ph.CreatePerson(45, "John", "Smith", 1.87, 88.5);
            Console.WriteLine($"{person.Age}, {person.Fname}, {person.Lname}, {person.Height}, {person.Weight}");

            //PersonHandler ph2 = new PersonHandler();
            Person person2 = ph.CreatePerson(45, "John", "Smith");
            Console.WriteLine($"{person2.Age}, {person2.Fname}, {person2.Lname}");

            //bool result;
            //result = Object.Equals(person, person2);
            //Console.WriteLine(result);

            //bool result2;
            //Person person3 = person2;
            //result2 = Object.Equals(person3, person2);
            //Console.WriteLine(result2);

            Animal monkey = new Animal("Monkey", 75, 10, "OHOHAHAH!");
            Console.WriteLine($"{monkey.Name}, {monkey.Weight}, {monkey.Age}, {monkey.Sound}");

            Bird raven = new Bird("Raven", 5, 2, "CRAAAAAAHHHH!", 0.75);
            Console.WriteLine($"{raven.Name}, {raven.Weight}, {raven.Age}, {raven.Sound}, {raven.WingSpan}");

            Horse horse = new Horse("Horse", 5, 2, "WHINNYING!", "Shetland");
            Console.WriteLine($"{horse.Name}, {horse.Weight}, {horse.Age}, {horse.Sound}, {horse.Race}");

            Dog dog = new Dog("Dog", 5, 2, "WOOOOFFF!", true);
            Console.WriteLine($"{dog.Name}, {dog.Weight}, {dog.Age}, {dog.Sound}, {dog.HasLeash}");

            Console.WriteLine(monkey.Stats());

            Console.WriteLine(raven.Stats());

            //List<Animal> animals = new List<Animal>

            var animals = new List<Animal>();
            animals.Add(monkey);
            animals.Add(raven);
            animals.Add(horse);
            animals.Add(dog);

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.Name);
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.Stats());
            }

            foreach (var animal in animals)
            {
               // Console.WriteLine(animal.Bark());
                if (animal is Dog ddd)
                {
                    //Unsafecast exeption
                    var d = (Dog)animal;
                    //Safe cast null
                    var dd = animal as Dog;
                    Console.WriteLine(d.Bark());
                    dd.Bark();
                    ddd.Bark();

                    Console.WriteLine(dog.Stats());
                }
            }

            foreach (var animal in animals)
            {
                if (animal == dog)
                {
                    Console.WriteLine(dog.Bark());
                }
            }

            TextInputError textInputError = new TextInputError();
            NumericInputError numericInputError = new NumericInputError();
            SyntaxError syntaxError = new SyntaxError();
            DatabaseError databaseError = new DatabaseError();
            BackEndError backEndError = new BackEndError();

            var userErrors = new List<UserError>();
            userErrors.Add(textInputError);
            userErrors.Add(numericInputError);
            userErrors.Add(textInputError);
            userErrors.Add(numericInputError);
            userErrors.Add(textInputError);
            userErrors.Add(numericInputError);
            userErrors.Add(syntaxError);
            userErrors.Add(databaseError);
            userErrors.Add(backEndError);

            foreach (var userError in userErrors)
            {
                Console.WriteLine(userError.UEMessage());
            }




            //Lite kladd här nere :)



            //var dogs = new List<Dog>();
            //dogs.Add(horse);

            //För att initsialisera en lista på detta sätt, kolla pluralsight iterfaces kapitel 2 Demo: Concrete class vs Interface

            //var djur = new List<Animal>();

            //djur.Add(new Animal()
            //{ Name = "Gorilla", Weight = 150, Age = 13, Sound = "Oh Oh Ah Ah!" });


            //    List<Gubbe> gubbar;
            //    gubbar = GetGubbar();

            //}

            //public List<Gubbe> GetGubbar()
            //{
            //    var gubbar = new List<Gubbe>
            //    {
            //        new Gubbe() { FirstName="John", LastName="Koenig",
            //            StartDate = DateTime.Parse("10/17/1975"), Rating=6 },
            //        new Gubbe() { FirstName="Dylan", LastName="Hunt",
            //            StartDate = DateTime.Parse("10/02/2000"), Rating=8 },
            //        new Gubbe() { FirstName="John", LastName="Crichton",
            //            StartDate = DateTime.Parse("03/19/1999"), Rating=7 },
            //        new Gubbe() { FirstName="Dave", LastName="Lister",
            //            StartDate = DateTime.Parse("02/15/1988"), Rating=9 },
            //        new Gubbe() { FirstName="John", LastName="Sheridan",
            //            StartDate = DateTime.Parse("01/26/1994"), Rating=6 },
            //        new Gubbe() { FirstName="Dante", LastName="Montana",
            //            StartDate = DateTime.Parse("11/01/2000"), Rating=5 },
            //        new Gubbe() { FirstName="Isaac", LastName="Gampu",
            //            StartDate = DateTime.Parse("09/10/1977"), Rating=4 }
            //    };
            //    return gubbar;
            //}
        }
    }
}
