using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationInheritancePolymorphism
{
    public class Gubbe
    {
		private int age;
		private string fName;
		private string lName;
		private double height;
		private double weight;

		//Här kan man overloada constructor med olika signaturer (beteenden)
		public Gubbe(int age, string fname, string lname, double height, double weight)
		{
			Age = age;
			Fname = fname;
			Lname = lname;
			Height = height;
			Weight = weight;
		}

		//Constructor med en annan signatur (beteende)
		public Gubbe(int age, string fname, string lname)
		{
			Age = age;
			Fname = fname;
			Lname = lname;
		}

		public Gubbe()
		{
		}

		public int Age
		{
			get { return age; }
			set { age = value; }
		}
		public string Fname
		{
			get { return fName; }
			set { fName = value; }
		}
		public string Lname
		{
			get { return lName; }
			set { lName = value; }
		}
		public double Weight
		{
			get { return weight; }
			set { weight = value; }
		}
		public double Height
		{
			get { return height; }
			set { height = value; }
		}

	}
}
