using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
	internal class Person
	{
		public string Name;
		public int Alter;
		public string Beruf;

		public Person(string wert1, int wert2 , string wert3) 
		{ 
			Name = wert1;
			Alter = wert2;
			Beruf = wert3;
		}

		public void Begruessung(string userName) 
		{
            Console.WriteLine($"Hallo {userName} ich bin {Name}.");
        }

		public void Infos()
		{
            Console.WriteLine($"Name: {Name}\nAlter: {Alter}\nBeruf: {Beruf}");
        }
	}
}
